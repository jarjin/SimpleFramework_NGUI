using System;
using com.junfine.simpleframework.manager;
using UnityEngine;
using LuaInterface;
using Object = UnityEngine.Object;

public class com_junfine_simpleframework_manager_ResourceManagerWrap
{
	public static LuaMethod[] regs = new LuaMethod[]
	{
		new LuaMethod("initialize", initialize),
		new LuaMethod("LoadBundle", LoadBundle),
		new LuaMethod("New", _Createcom_junfine_simpleframework_manager_ResourceManager),
		new LuaMethod("GetClassType", GetClassType),
		new LuaMethod("__eq", Lua_Eq),
	};

	static LuaField[] fields = new LuaField[]
	{
	};

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _Createcom_junfine_simpleframework_manager_ResourceManager(IntPtr L)
	{
		LuaDLL.luaL_error(L, "com.junfine.simpleframework.manager.ResourceManager class does not have a constructor function");
		return 0;
	}

	static Type classType = typeof(com.junfine.simpleframework.manager.ResourceManager);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);

		return 1;
	}

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "com.junfine.simpleframework.manager.ResourceManager", typeof(com.junfine.simpleframework.manager.ResourceManager), regs, fields, typeof(MonoBehaviour));
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int initialize(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		com.junfine.simpleframework.manager.ResourceManager obj = (com.junfine.simpleframework.manager.ResourceManager)LuaScriptMgr.GetUnityObject(L, 1, typeof(com.junfine.simpleframework.manager.ResourceManager));
		Action arg0 = (Action)LuaScriptMgr.GetNetObject(L, 2, typeof(Action));
		obj.initialize(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LoadBundle(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		com.junfine.simpleframework.manager.ResourceManager obj = (com.junfine.simpleframework.manager.ResourceManager)LuaScriptMgr.GetUnityObject(L, 1, typeof(com.junfine.simpleframework.manager.ResourceManager));
		string arg0 = LuaScriptMgr.GetLuaString(L, 2);
		AssetBundle o = obj.LoadBundle(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
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

