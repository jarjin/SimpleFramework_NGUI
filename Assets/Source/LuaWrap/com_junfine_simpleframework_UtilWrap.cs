using System;
using com.junfine.simpleframework;
using UnityEngine;
using LuaInterface;
using Object = UnityEngine.Object;

public class com_junfine_simpleframework_UtilWrap
{
	public static LuaMethod[] regs = new LuaMethod[]
	{
		new LuaMethod("Int", Int),
		new LuaMethod("Float", Float),
		new LuaMethod("Long", Long),
		new LuaMethod("Random", Random),
		new LuaMethod("Uid", Uid),
		new LuaMethod("GetTime", GetTime),
		new LuaMethod("Child", Child),
		new LuaMethod("Peer", Peer),
		new LuaMethod("Vibrate", Vibrate),
		new LuaMethod("Encode", Encode),
		new LuaMethod("Decode", Decode),
		new LuaMethod("IsNumeric", IsNumeric),
		new LuaMethod("HashToMD5Hex", HashToMD5Hex),
		new LuaMethod("md5", md5),
		new LuaMethod("md5file", md5file),
		new LuaMethod("CompressFile", CompressFile),
		new LuaMethod("DecompressFile", DecompressFile),
		new LuaMethod("Compress", Compress),
		new LuaMethod("Decompress", Decompress),
		new LuaMethod("ClearChild", ClearChild),
		new LuaMethod("GetKey", GetKey),
		new LuaMethod("GetInt", GetInt),
		new LuaMethod("HasKey", HasKey),
		new LuaMethod("SetInt", SetInt),
		new LuaMethod("GetString", GetString),
		new LuaMethod("SetString", SetString),
		new LuaMethod("RemoveData", RemoveData),
		new LuaMethod("ClearMemory", ClearMemory),
		new LuaMethod("IsNumber", IsNumber),
		new LuaMethod("GetFileText", GetFileText),
		new LuaMethod("AppContentPath", AppContentPath),
		new LuaMethod("AddClick", AddClick),
		new LuaMethod("LuaPath", LuaPath),
		new LuaMethod("Log", Log),
		new LuaMethod("LogWarning", LogWarning),
		new LuaMethod("LogError", LogError),
		new LuaMethod("LoadAsset", LoadAsset),
		new LuaMethod("AddComponent", AddComponent),
		new LuaMethod("PushBufferToLua", PushBufferToLua),
		new LuaMethod("New", _Createcom_junfine_simpleframework_Util),
		new LuaMethod("GetClassType", GetClassType),
	};

	static LuaField[] fields = new LuaField[]
	{
		new LuaField("DataPath", get_DataPath, null),
		new LuaField("NetAvailable", get_NetAvailable, null),
		new LuaField("IsWifi", get_IsWifi, null),
		new LuaField("isLogin", get_isLogin, null),
		new LuaField("isMain", get_isMain, null),
		new LuaField("isFight", get_isFight, null),
	};

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _Createcom_junfine_simpleframework_Util(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 0)
		{
			com.junfine.simpleframework.Util obj = new com.junfine.simpleframework.Util();
			LuaScriptMgr.PushObject(L, obj);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: com.junfine.simpleframework.Util.New");
		}

		return 0;
	}

	static Type classType = typeof(com.junfine.simpleframework.Util);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);

		return 1;
	}

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "com.junfine.simpleframework.Util", typeof(com.junfine.simpleframework.Util), regs, fields, typeof(object));
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_DataPath(IntPtr L)
	{
		LuaScriptMgr.Push(L, com.junfine.simpleframework.Util.DataPath);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_NetAvailable(IntPtr L)
	{
		LuaScriptMgr.Push(L, com.junfine.simpleframework.Util.NetAvailable);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_IsWifi(IntPtr L)
	{
		LuaScriptMgr.Push(L, com.junfine.simpleframework.Util.IsWifi);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_isLogin(IntPtr L)
	{
		LuaScriptMgr.Push(L, com.junfine.simpleframework.Util.isLogin);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_isMain(IntPtr L)
	{
		LuaScriptMgr.Push(L, com.junfine.simpleframework.Util.isMain);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_isFight(IntPtr L)
	{
		LuaScriptMgr.Push(L, com.junfine.simpleframework.Util.isFight);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Int(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		object arg0 = LuaScriptMgr.GetVarObject(L, 1);
		int o = com.junfine.simpleframework.Util.Int(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Float(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		object arg0 = LuaScriptMgr.GetVarObject(L, 1);
		float o = com.junfine.simpleframework.Util.Float(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Long(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		object arg0 = LuaScriptMgr.GetVarObject(L, 1);
		long o = com.junfine.simpleframework.Util.Long(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Random(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 2 && LuaScriptMgr.CheckTypes(L, 1, typeof(float), typeof(float)))
		{
			float arg0 = (float)LuaScriptMgr.GetNumber(L, 1);
			float arg1 = (float)LuaScriptMgr.GetNumber(L, 2);
			float o = com.junfine.simpleframework.Util.Random(arg0,arg1);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 2 && LuaScriptMgr.CheckTypes(L, 1, typeof(int), typeof(int)))
		{
			int arg0 = (int)LuaScriptMgr.GetNumber(L, 1);
			int arg1 = (int)LuaScriptMgr.GetNumber(L, 2);
			int o = com.junfine.simpleframework.Util.Random(arg0,arg1);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: com.junfine.simpleframework.Util.Random");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Uid(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		string arg0 = LuaScriptMgr.GetLuaString(L, 1);
		string o = com.junfine.simpleframework.Util.Uid(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetTime(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 0);
		long o = com.junfine.simpleframework.Util.GetTime();
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Child(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 2 && LuaScriptMgr.CheckTypes(L, 1, typeof(Transform), typeof(string)))
		{
			Transform arg0 = (Transform)LuaScriptMgr.GetUnityObject(L, 1, typeof(Transform));
			string arg1 = LuaScriptMgr.GetString(L, 2);
			GameObject o = com.junfine.simpleframework.Util.Child(arg0,arg1);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 2 && LuaScriptMgr.CheckTypes(L, 1, typeof(GameObject), typeof(string)))
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
			string arg1 = LuaScriptMgr.GetString(L, 2);
			GameObject o = com.junfine.simpleframework.Util.Child(arg0,arg1);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: com.junfine.simpleframework.Util.Child");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Peer(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 2 && LuaScriptMgr.CheckTypes(L, 1, typeof(Transform), typeof(string)))
		{
			Transform arg0 = (Transform)LuaScriptMgr.GetUnityObject(L, 1, typeof(Transform));
			string arg1 = LuaScriptMgr.GetString(L, 2);
			GameObject o = com.junfine.simpleframework.Util.Peer(arg0,arg1);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 2 && LuaScriptMgr.CheckTypes(L, 1, typeof(GameObject), typeof(string)))
		{
			GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
			string arg1 = LuaScriptMgr.GetString(L, 2);
			GameObject o = com.junfine.simpleframework.Util.Peer(arg0,arg1);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: com.junfine.simpleframework.Util.Peer");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Vibrate(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 0);
		com.junfine.simpleframework.Util.Vibrate();
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Encode(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		string arg0 = LuaScriptMgr.GetLuaString(L, 1);
		string o = com.junfine.simpleframework.Util.Encode(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Decode(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		string arg0 = LuaScriptMgr.GetLuaString(L, 1);
		string o = com.junfine.simpleframework.Util.Decode(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IsNumeric(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		string arg0 = LuaScriptMgr.GetLuaString(L, 1);
		bool o = com.junfine.simpleframework.Util.IsNumeric(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int HashToMD5Hex(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		string arg0 = LuaScriptMgr.GetLuaString(L, 1);
		string o = com.junfine.simpleframework.Util.HashToMD5Hex(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int md5(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		string arg0 = LuaScriptMgr.GetLuaString(L, 1);
		string o = com.junfine.simpleframework.Util.md5(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int md5file(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		string arg0 = LuaScriptMgr.GetLuaString(L, 1);
		string o = com.junfine.simpleframework.Util.md5file(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CompressFile(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		string arg0 = LuaScriptMgr.GetLuaString(L, 1);
		string arg1 = LuaScriptMgr.GetLuaString(L, 2);
		com.junfine.simpleframework.Util.CompressFile(arg0,arg1);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DecompressFile(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		string arg0 = LuaScriptMgr.GetLuaString(L, 1);
		string o = com.junfine.simpleframework.Util.DecompressFile(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Compress(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		string arg0 = LuaScriptMgr.GetLuaString(L, 1);
		string o = com.junfine.simpleframework.Util.Compress(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Decompress(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		string arg0 = LuaScriptMgr.GetLuaString(L, 1);
		string o = com.junfine.simpleframework.Util.Decompress(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ClearChild(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		Transform arg0 = (Transform)LuaScriptMgr.GetUnityObject(L, 1, typeof(Transform));
		com.junfine.simpleframework.Util.ClearChild(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetKey(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		string arg0 = LuaScriptMgr.GetLuaString(L, 1);
		string o = com.junfine.simpleframework.Util.GetKey(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetInt(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		string arg0 = LuaScriptMgr.GetLuaString(L, 1);
		int o = com.junfine.simpleframework.Util.GetInt(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int HasKey(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		string arg0 = LuaScriptMgr.GetLuaString(L, 1);
		bool o = com.junfine.simpleframework.Util.HasKey(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetInt(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		string arg0 = LuaScriptMgr.GetLuaString(L, 1);
		int arg1 = (int)LuaScriptMgr.GetNumber(L, 2);
		com.junfine.simpleframework.Util.SetInt(arg0,arg1);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetString(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		string arg0 = LuaScriptMgr.GetLuaString(L, 1);
		string o = com.junfine.simpleframework.Util.GetString(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetString(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		string arg0 = LuaScriptMgr.GetLuaString(L, 1);
		string arg1 = LuaScriptMgr.GetLuaString(L, 2);
		com.junfine.simpleframework.Util.SetString(arg0,arg1);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RemoveData(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		string arg0 = LuaScriptMgr.GetLuaString(L, 1);
		com.junfine.simpleframework.Util.RemoveData(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ClearMemory(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 0);
		com.junfine.simpleframework.Util.ClearMemory();
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IsNumber(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		string arg0 = LuaScriptMgr.GetLuaString(L, 1);
		bool o = com.junfine.simpleframework.Util.IsNumber(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetFileText(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		string arg0 = LuaScriptMgr.GetLuaString(L, 1);
		string o = com.junfine.simpleframework.Util.GetFileText(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AppContentPath(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 0);
		string o = com.junfine.simpleframework.Util.AppContentPath();
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddClick(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
		object arg1 = LuaScriptMgr.GetVarObject(L, 2);
		com.junfine.simpleframework.Util.AddClick(arg0,arg1);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LuaPath(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);
		if (count == 0)
		{
			string o = com.junfine.simpleframework.Util.LuaPath();
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 1)
		{
			string arg0 = LuaScriptMgr.GetLuaString(L, 1);
			string o = com.junfine.simpleframework.Util.LuaPath(arg0);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: com.junfine.simpleframework.Util.LuaPath");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Log(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		string arg0 = LuaScriptMgr.GetLuaString(L, 1);
		com.junfine.simpleframework.Util.Log(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LogWarning(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		string arg0 = LuaScriptMgr.GetLuaString(L, 1);
		com.junfine.simpleframework.Util.LogWarning(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LogError(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		string arg0 = LuaScriptMgr.GetLuaString(L, 1);
		com.junfine.simpleframework.Util.LogError(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LoadAsset(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		AssetBundle arg0 = (AssetBundle)LuaScriptMgr.GetUnityObject(L, 1, typeof(AssetBundle));
		string arg1 = LuaScriptMgr.GetLuaString(L, 2);
		GameObject o = com.junfine.simpleframework.Util.LoadAsset(arg0,arg1);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddComponent(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 3);
		GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
		string arg1 = LuaScriptMgr.GetLuaString(L, 2);
		string arg2 = LuaScriptMgr.GetLuaString(L, 3);
		Component o = com.junfine.simpleframework.Util.AddComponent(arg0,arg1,arg2);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int PushBufferToLua(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		LuaFunction arg0 = LuaScriptMgr.GetLuaFunction(L, 1);
		byte[] objs1 = LuaScriptMgr.GetArrayNumber<byte>(L, 2);
		com.junfine.simpleframework.Util.PushBufferToLua(arg0,objs1);
		return 0;
	}
}

