using UnityEditor;
using UnityEngine;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using com.junfine.simpleframework;

public class Packager {
    public static string platform = string.Empty;
    static List<string> paths = new List<string>();
    static List<string> files = new List<string>();

    ///-----------------------------------------------------------
    static string[] exts = { ".txt", ".xml", ".lua", ".assetbundle", ".json" };
    static bool CanCopy(string ext) {   //能不能复制
        foreach (string e in exts) {
            if (ext.Equals(e)) return true;
        }
        return false;
    }

    /// <summary>
    /// 载入素材
    /// </summary>
    static UnityEngine.Object LoadAsset(string file) {
        if (file.EndsWith(".lua")) file += ".txt";
        return AssetDatabase.LoadMainAssetAtPath("Assets/Builds/" + file);
    }

    [MenuItem("Game/Build iPhone Resource", false, 11)]
    public static void BuildiPhoneResource() { 
        BuildTarget target;
#if UNITY_5
        target = BuildTarget.iOS;
#else
        target = BuildTarget.iPhone;
#endif
        BuildAssetResource(target);
    }

    [MenuItem("Game/Build Android Resource", false, 12)]
    public static void BuildAndroidResource() {
        BuildAssetResource(BuildTarget.Android);
    }

    [MenuItem("Game/Build Windows Resource", false, 13)]
    public static void BuildWindowsResource() {
        BuildAssetResource(BuildTarget.StandaloneWindows);
    }

    /// <summary>
    /// 生成绑定素材
    /// </summary>
    public static void BuildAssetResource(BuildTarget target) {
        Object mainAsset = null;        //主素材名，单个
        Object[] addis = null;     //附加素材名，多个
        string assetfile = string.Empty;  //素材文件名

        BuildAssetBundleOptions options = BuildAssetBundleOptions.UncompressedAssetBundle | 
                                          BuildAssetBundleOptions.CollectDependencies | 
                                          BuildAssetBundleOptions.DeterministicAssetBundle;
        string dataPath = Util.DataPath;
        if (Directory.Exists(dataPath)) {
            Directory.Delete(dataPath, true);
        }
        string assetPath = AppDataPath + "/StreamingAssets/";
        if (!Directory.Exists(assetPath)) Directory.CreateDirectory(assetPath);

        ///-----------------------------生成共享的关联性素材绑定-------------------------------------
        BuildPipeline.PushAssetDependencies();

        assetfile = assetPath + "shared.assetbundle";
        mainAsset = LoadAsset("Shared/Atlas/Dialog.prefab");
        BuildPipeline.BuildAssetBundle(mainAsset, null, assetfile, options, target);

        ///------------------------------生成PromptPanel素材绑定-----------------------------------
        BuildPipeline.PushAssetDependencies();
        mainAsset = LoadAsset("Prompt/Prefabs/PromptPanel.prefab");
        addis = new Object[1];
        addis[0] = LoadAsset("Prompt/Prefabs/PromptItem.prefab");
        assetfile = assetPath + "prompt.assetbundle";
        BuildPipeline.BuildAssetBundle(mainAsset, addis, assetfile, options, target);
        BuildPipeline.PopAssetDependencies();

        ///------------------------------生成MessagePanel素材绑定-----------------------------------
        BuildPipeline.PushAssetDependencies();
        mainAsset = LoadAsset("Message/Prefabs/MessagePanel.prefab");
        assetfile = assetPath + "message.assetbundle";
        BuildPipeline.BuildAssetBundle(mainAsset, null, assetfile, options, target);
        BuildPipeline.PopAssetDependencies();

        ///-------------------------------刷新---------------------------------------
        BuildPipeline.PopAssetDependencies();

        HandleLuaFile();
        AssetDatabase.Refresh();
    }

    /// <summary>
    /// 处理Lua文件
    /// </summary>
    static void HandleLuaFile() {
        string resPath = AppDataPath + "/StreamingAssets/";
        string luaPath = resPath + "/lua/";

        //----------复制Lua文件----------------
        if (Directory.Exists(luaPath)) {
            Directory.Delete(luaPath, true);
        }
        Directory.CreateDirectory(luaPath);

        paths.Clear(); files.Clear();
        string luaDataPath = AppDataPath + "/lua/".ToLower();
        Recursive(luaDataPath);
        foreach (string f in files) {
            if (f.EndsWith(".meta")) continue;
            string newfile = f.Replace(luaDataPath, "");
            string newpath = luaPath + newfile;
            string path = Path.GetDirectoryName(newpath);
            if (!Directory.Exists(path)) Directory.CreateDirectory(path);
            File.Copy(f, newpath, true);
        }

        ///----------------------创建文件列表-----------------------
        string newFilePath = resPath + "/files.txt";
        if (File.Exists(newFilePath)) File.Delete(newFilePath);

        paths.Clear(); files.Clear();
        Recursive(resPath);

        FileStream fs = new FileStream(newFilePath, FileMode.CreateNew);
        StreamWriter sw = new StreamWriter(fs);
        for (int i = 0; i < files.Count; i++) {
            string file = files[i];
            string ext = Path.GetExtension(file);
            if (file.EndsWith(".meta")) continue;

            string md5 = Util.md5file(file);
            string value = file.Replace(resPath, string.Empty); 
            sw.WriteLine(value + "|" + md5);
        }
        sw.Close(); fs.Close();

        AssetDatabase.Refresh();
    }

    /// <summary>
    /// 数据目录
    /// </summary>
    static string AppDataPath {
        get { return Application.dataPath.ToLower(); }
    }

    /// <summary>
    /// 遍历目录及其子目录
    /// </summary>
    static void Recursive(string path) {
        string[] names = Directory.GetFiles(path);
        string[] dirs = Directory.GetDirectories(path);
        foreach (string filename in names) {
            string ext = Path.GetExtension(filename);
            if (ext.Equals(".meta")) continue;
            files.Add(filename.Replace('\\', '/'));
        }
        foreach (string dir in dirs) {
            paths.Add(dir.Replace('\\', '/'));
            Recursive(dir);
        }
    }

    [MenuItem("Game/Build Protobuf-lua-gen File")]
    public static void BuildProtobufFile() {
        string dir = AppDataPath + "/Lua/bin";
        paths.Clear(); files.Clear(); Recursive(dir);

        string protoc = "d:/protobuf-2.4.1/src/protoc.exe";
        string protoc_gen_dir = "\"d:/protoc-gen-lua/plugin/protoc-gen-lua.bat\"";

        foreach (string f in files) {
            string name = Path.GetFileName(f);
            string ext = Path.GetExtension(f);
            if (!ext.Equals(".proto")) continue;

            ProcessStartInfo info = new ProcessStartInfo();
            info.FileName = protoc;
            info.Arguments = " --lua_out=./ --plugin=protoc-gen-lua=" + protoc_gen_dir + " " + name;
            info.WindowStyle = ProcessWindowStyle.Minimized;
            info.UseShellExecute = true;
            info.WorkingDirectory = dir;
            info.ErrorDialog = true;
            Util.Log(info.FileName + " " + info.Arguments);

            Process pro = Process.Start(info);
            pro.WaitForExit();
        }
        AssetDatabase.Refresh();
    }
}