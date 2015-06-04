using System;
using com.junfine.simpleframework;
using UnityEngine;
using LuaInterface;
using Object = UnityEngine.Object;

public class com_junfine_simpleframework_BaseLuaWrap
{
	public static LuaMethod[] regs = new LuaMethod[]
	{
		new LuaMethod("OnInit", OnInit),
		new LuaMethod("GetGameObject", GetGameObject),
		new LuaMethod("AddClick", AddClick),
		new LuaMethod("ClearClick", ClearClick),
		new LuaMethod("New", _Createcom_junfine_simpleframework_BaseLua),
		new LuaMethod("GetClassType", GetClassType),
		new LuaMethod("__eq", Lua_Eq),
	};

	static LuaField[] fields = new LuaField[]
	{
	};

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _Createcom_junfine_simpleframework_BaseLua(IntPtr L)
	{
		LuaDLL.luaL_error(L, "com.junfine.simpleframework.BaseLua class does not have a constructor function");
		return 0;
	}

	static Type classType = typeof(com.junfine.simpleframework.BaseLua);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);

		return 1;
	}

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "com.junfine.simpleframework.BaseLua", typeof(com.junfine.simpleframework.BaseLua), regs, fields, typeof(MonoBehaviour));
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnInit(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 3);
		com.junfine.simpleframework.BaseLua obj = (com.junfine.simpleframework.BaseLua)LuaScriptMgr.GetUnityObject(L, 1, typeof(com.junfine.simpleframework.BaseLua));
		AssetBundle arg0 = (AssetBundle)LuaScriptMgr.GetUnityObject(L, 2, typeof(AssetBundle));
		string arg1 = LuaScriptMgr.GetLuaString(L, 3);
		obj.OnInit(arg0,arg1);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetGameObject(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		com.junfine.simpleframework.BaseLua obj = (com.junfine.simpleframework.BaseLua)LuaScriptMgr.GetUnityObject(L, 1, typeof(com.junfine.simpleframework.BaseLua));
		string arg0 = LuaScriptMgr.GetLuaString(L, 2);
		GameObject o = obj.GetGameObject(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddClick(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 3);
		com.junfine.simpleframework.BaseLua obj = (com.junfine.simpleframework.BaseLua)LuaScriptMgr.GetUnityObject(L, 1, typeof(com.junfine.simpleframework.BaseLua));
		string arg0 = LuaScriptMgr.GetLuaString(L, 2);
		LuaFunction arg1 = LuaScriptMgr.GetLuaFunction(L, 3);
		obj.AddClick(arg0,arg1);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ClearClick(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		com.junfine.simpleframework.BaseLua obj = (com.junfine.simpleframework.BaseLua)LuaScriptMgr.GetUnityObject(L, 1, typeof(com.junfine.simpleframework.BaseLua));
		obj.ClearClick();
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

