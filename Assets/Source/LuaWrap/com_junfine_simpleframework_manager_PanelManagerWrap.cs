using System;
using com.junfine.simpleframework.manager;
using UnityEngine;
using LuaInterface;
using Object = UnityEngine.Object;

public class com_junfine_simpleframework_manager_PanelManagerWrap
{
	public static LuaMethod[] regs = new LuaMethod[]
	{
		new LuaMethod("CreatePanel", CreatePanel),
		new LuaMethod("New", _Createcom_junfine_simpleframework_manager_PanelManager),
		new LuaMethod("GetClassType", GetClassType),
		new LuaMethod("__eq", Lua_Eq),
	};

	static LuaField[] fields = new LuaField[]
	{
	};

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _Createcom_junfine_simpleframework_manager_PanelManager(IntPtr L)
	{
		LuaDLL.luaL_error(L, "com.junfine.simpleframework.manager.PanelManager class does not have a constructor function");
		return 0;
	}

	static Type classType = typeof(com.junfine.simpleframework.manager.PanelManager);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);

		return 1;
	}

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "com.junfine.simpleframework.manager.PanelManager", typeof(com.junfine.simpleframework.manager.PanelManager), regs, fields, typeof(MonoBehaviour));
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CreatePanel(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		com.junfine.simpleframework.manager.PanelManager obj = (com.junfine.simpleframework.manager.PanelManager)LuaScriptMgr.GetUnityObject(L, 1, typeof(com.junfine.simpleframework.manager.PanelManager));
		string arg0 = LuaScriptMgr.GetLuaString(L, 2);
		obj.CreatePanel(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Lua_Eq(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		Object arg0 = LuaScriptMgr.GetLuaObject(L, 1) as Object;
		Object arg1 = LuaScriptMgr.GetLuaObject(L, 2) as Object;
		bool o = arg0 == arg1;
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

