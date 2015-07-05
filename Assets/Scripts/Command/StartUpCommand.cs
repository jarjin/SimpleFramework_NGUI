using UnityEngine;
using System.Collections;
using PureMVC.Patterns;
using PureMVC.Interfaces;
using SimpleFramework;
using SimpleFramework.Manager;
using UnityEditor;

public class StartUpCommand : SimpleCommand {

    /// <summary>
    /// 执行启动命令
    /// </summary>
    /// <param name="notification"></param>
    public override void Execute(INotification notification) {
        int resultId = Util.CheckRuntimeFile();
        if (resultId == -1) {
            Debug.LogError("没有找到框架所需要的资源，单击Game菜单下Build xxx Resource生成！！");
            EditorApplication.isPlaying = false;
            return;
        } else if (resultId == -2) {
            Debug.LogError("没有找到Wrap脚本缓存，单击Lua菜单下Gen Lua Wrap Files生成脚本！！");
            EditorApplication.isPlaying = false;
            return;
        }

        //-----------------初始化管理器-----------------------
        Facade.AddManager(ManagerName.Lua, new LuaScriptMgr());

        Facade.AddManager<PanelManager>(ManagerName.Panel);
        Facade.AddManager<MusicManager>(ManagerName.Music);
        Facade.AddManager<TimerManager>(ManagerName.Timer);
        Facade.AddManager<NetworkManager>(ManagerName.Network);
        Facade.AddManager<ResourceManager>(ManagerName.Resource);
        Facade.AddManager<GameManager>(ManagerName.Game);

        Debug.Log("SimpleFramework StartUp-------->>>>>");
    }
}