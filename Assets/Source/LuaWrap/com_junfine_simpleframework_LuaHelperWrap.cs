using System;
using com.junfine.simpleframework;
using UnityEngine;
using LuaInterface;
using Object = UnityEngine.Object;

public class com_junfine_simpleframework_LuaHelperWrap
{
	public static LuaMethod[] regs = new LuaMethod[]
	{
		new LuaMethod("GetType", GetType),
		new LuaMethod("GetComponentInChildren", GetComponentInChildren),
		new LuaMethod("GetComponent", GetComponent),
		new LuaMethod("GetComponentsInChildren", GetComponentsInChildren),
		new LuaMethod("GetAllChild", GetAllChild),
		new LuaMethod("Action", Action),
		new LuaMethod("VoidDelegate", VoidDelegate),
		new LuaMethod("OnCallLuaFunc", OnCallLuaFunc),
		new LuaMethod("OnJsonCallFunc", OnJsonCallFunc),
		new LuaMethod("New", _Createcom_junfine_simpleframework_LuaHelper),
		new LuaMethod("GetClassType", GetClassType),
	};


	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _Createcom_junfine_simpleframework_LuaHelper(IntPtr L)
	{
		LuaDLL.luaL_error(L, "com.junfine.simpleframework.LuaHelper class does not have a constructor function");
		return 0;
	}

	static Type classType = typeof(com.junfine.simpleframework.LuaHelper);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);

		return 1;
	}

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "com.junfine.simpleframework.LuaHelper", regs);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetType(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		string arg0 = LuaScriptMgr.GetLuaString(L, 1);
		Type o = com.junfine.simpleframework.LuaHelper.GetType(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetComponentInChildren(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
		string arg1 = LuaScriptMgr.GetLuaString(L, 2);
		Component o = com.junfine.simpleframework.LuaHelper.GetComponentInChildren(arg0,arg1);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetComponent(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
		string arg1 = LuaScriptMgr.GetLuaString(L, 2);
		Component o = com.junfine.simpleframework.LuaHelper.GetComponent(arg0,arg1);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetComponentsInChildren(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
		string arg1 = LuaScriptMgr.GetLuaString(L, 2);
		Component[] o = com.junfine.simpleframework.LuaHelper.GetComponentsInChildren(arg0,arg1);
		LuaScriptMgr.PushArray(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetAllChild(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
		Transform[] o = com.junfine.simpleframework.LuaHelper.GetAllChild(arg0);
		LuaScriptMgr.PushArray(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Action(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		LuaFunction arg0 = LuaScriptMgr.GetLuaFunction(L, 1);
		Action o = com.junfine.simpleframework.LuaHelper.Action(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int VoidDelegate(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		LuaFunction arg0 = LuaScriptMgr.GetLuaFunction(L, 1);
		UIEventListener.VoidDelegate o = com.junfine.simpleframework.LuaHelper.VoidDelegate(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnCallLuaFunc(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		LuaStringBuffer arg0 = LuaScriptMgr.GetStringBuffer(L, 1);
		LuaFunction arg1 = LuaScriptMgr.GetLuaFunction(L, 2);
		com.junfine.simpleframework.LuaHelper.OnCallLuaFunc(arg0,arg1);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnJsonCallFunc(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		string arg0 = LuaScriptMgr.GetLuaString(L, 1);
		LuaFunction arg1 = LuaScriptMgr.GetLuaFunction(L, 2);
		com.junfine.simpleframework.LuaHelper.OnJsonCallFunc(arg0,arg1);
		return 0;
	}
}

