using System;
using com.junfine.simpleframework;
using UnityEngine;
using LuaInterface;
using Object = UnityEngine.Object;

public class com_junfine_simpleframework_iooWrap
{
	public static LuaMethod[] regs = new LuaMethod[]
	{
		new LuaMethod("f", f),
		new LuaMethod("c", c),
		new LuaMethod("AddPrefab", AddPrefab),
		new LuaMethod("GetPrefab", GetPrefab),
		new LuaMethod("RemovePrefab", RemovePrefab),
		new LuaMethod("LoadPrefab", LoadPrefab),
		new LuaMethod("New", _Createcom_junfine_simpleframework_ioo),
		new LuaMethod("GetClassType", GetClassType),
	};

	static LuaField[] fields = new LuaField[]
	{
		new LuaField("manager", get_manager, null),
		new LuaField("gameManager", get_gameManager, null),
		new LuaField("panelManager", get_panelManager, null),
		new LuaField("resourceManager", get_resourceManager, null),
		new LuaField("timerManager", get_timerManager, null),
		new LuaField("musicManager", get_musicManager, null),
		new LuaField("networkManager", get_networkManager, null),
		new LuaField("MainUI", get_MainUI, null),
		new LuaField("guiCamera", get_guiCamera, null),
	};

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _Createcom_junfine_simpleframework_ioo(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 0)
		{
			com.junfine.simpleframework.ioo obj = new com.junfine.simpleframework.ioo();
			LuaScriptMgr.PushObject(L, obj);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: com.junfine.simpleframework.ioo.New");
		}

		return 0;
	}

	static Type classType = typeof(com.junfine.simpleframework.ioo);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);

		return 1;
	}

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "com.junfine.simpleframework.ioo", typeof(com.junfine.simpleframework.ioo), regs, fields, typeof(object));
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_manager(IntPtr L)
	{
		LuaScriptMgr.Push(L, com.junfine.simpleframework.ioo.manager);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_gameManager(IntPtr L)
	{
		LuaScriptMgr.Push(L, com.junfine.simpleframework.ioo.gameManager);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_panelManager(IntPtr L)
	{
		LuaScriptMgr.Push(L, com.junfine.simpleframework.ioo.panelManager);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_resourceManager(IntPtr L)
	{
		LuaScriptMgr.Push(L, com.junfine.simpleframework.ioo.resourceManager);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_timerManager(IntPtr L)
	{
		LuaScriptMgr.Push(L, com.junfine.simpleframework.ioo.timerManager);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_musicManager(IntPtr L)
	{
		LuaScriptMgr.Push(L, com.junfine.simpleframework.ioo.musicManager);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_networkManager(IntPtr L)
	{
		LuaScriptMgr.Push(L, com.junfine.simpleframework.ioo.networkManager);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_MainUI(IntPtr L)
	{
		LuaScriptMgr.Push(L, com.junfine.simpleframework.ioo.MainUI);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_guiCamera(IntPtr L)
	{
		LuaScriptMgr.Push(L, com.junfine.simpleframework.ioo.guiCamera);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int f(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);
		string arg0 = LuaScriptMgr.GetLuaString(L, 1);
		object[] objs1 = LuaScriptMgr.GetParamsObject(L, 2, count - 1);
		string o = com.junfine.simpleframework.ioo.f(arg0,objs1);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int c(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);
		object[] objs0 = LuaScriptMgr.GetParamsObject(L, 1, count);
		string o = com.junfine.simpleframework.ioo.c(objs0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddPrefab(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		string arg0 = LuaScriptMgr.GetLuaString(L, 1);
		GameObject arg1 = (GameObject)LuaScriptMgr.GetUnityObject(L, 2, typeof(GameObject));
		com.junfine.simpleframework.ioo.AddPrefab(arg0,arg1);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetPrefab(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		string arg0 = LuaScriptMgr.GetLuaString(L, 1);
		GameObject o = com.junfine.simpleframework.ioo.GetPrefab(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RemovePrefab(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		string arg0 = LuaScriptMgr.GetLuaString(L, 1);
		com.junfine.simpleframework.ioo.RemovePrefab(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LoadPrefab(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		string arg0 = LuaScriptMgr.GetLuaString(L, 1);
		GameObject o = com.junfine.simpleframework.ioo.LoadPrefab(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

