using System;
using com.junfine.simpleframework.manager;
using UnityEngine;
using LuaInterface;
using Object = UnityEngine.Object;

public class com_junfine_simpleframework_manager_NetworkManagerWrap
{
	public static LuaMethod[] regs = new LuaMethod[]
	{
		new LuaMethod("OnInit", OnInit),
		new LuaMethod("Unload", Unload),
		new LuaMethod("AddEvent", AddEvent),
		new LuaMethod("SendConnect", SendConnect),
		new LuaMethod("SendMessage", SendMessage),
		new LuaMethod("New", _Createcom_junfine_simpleframework_manager_NetworkManager),
		new LuaMethod("GetClassType", GetClassType),
		new LuaMethod("__eq", Lua_Eq),
	};

	static LuaField[] fields = new LuaField[]
	{
	};

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _Createcom_junfine_simpleframework_manager_NetworkManager(IntPtr L)
	{
		LuaDLL.luaL_error(L, "com.junfine.simpleframework.manager.NetworkManager class does not have a constructor function");
		return 0;
	}

	static Type classType = typeof(com.junfine.simpleframework.manager.NetworkManager);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);

		return 1;
	}

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "com.junfine.simpleframework.manager.NetworkManager", typeof(com.junfine.simpleframework.manager.NetworkManager), regs, fields, typeof(com.junfine.simpleframework.BaseLua));
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnInit(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		com.junfine.simpleframework.manager.NetworkManager obj = (com.junfine.simpleframework.manager.NetworkManager)LuaScriptMgr.GetUnityObject(L, 1, typeof(com.junfine.simpleframework.manager.NetworkManager));
		obj.OnInit();
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Unload(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		com.junfine.simpleframework.manager.NetworkManager obj = (com.junfine.simpleframework.manager.NetworkManager)LuaScriptMgr.GetUnityObject(L, 1, typeof(com.junfine.simpleframework.manager.NetworkManager));
		obj.Unload();
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddEvent(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		int arg0 = (int)LuaScriptMgr.GetNumber(L, 1);
		com.junfine.simpleframework.ByteBuffer arg1 = (com.junfine.simpleframework.ByteBuffer)LuaScriptMgr.GetNetObject(L, 2, typeof(com.junfine.simpleframework.ByteBuffer));
		com.junfine.simpleframework.manager.NetworkManager.AddEvent(arg0,arg1);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SendConnect(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		com.junfine.simpleframework.manager.NetworkManager obj = (com.junfine.simpleframework.manager.NetworkManager)LuaScriptMgr.GetUnityObject(L, 1, typeof(com.junfine.simpleframework.manager.NetworkManager));
		obj.SendConnect();
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SendMessage(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		com.junfine.simpleframework.manager.NetworkManager obj = (com.junfine.simpleframework.manager.NetworkManager)LuaScriptMgr.GetUnityObject(L, 1, typeof(com.junfine.simpleframework.manager.NetworkManager));
		com.junfine.simpleframework.ByteBuffer arg0 = (com.junfine.simpleframework.ByteBuffer)LuaScriptMgr.GetNetObject(L, 2, typeof(com.junfine.simpleframework.ByteBuffer));
		obj.SendMessage(arg0);
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

