using System;
using com.junfine.simpleframework.manager;
using UnityEngine;
using LuaInterface;
using Object = UnityEngine.Object;

public class com_junfine_simpleframework_manager_TimerManagerWrap
{
	public static LuaMethod[] regs = new LuaMethod[]
	{
		new LuaMethod("StartTimer", StartTimer),
		new LuaMethod("StopTimer", StopTimer),
		new LuaMethod("AddTimerEvent", AddTimerEvent),
		new LuaMethod("RemoveTimerEvent", RemoveTimerEvent),
		new LuaMethod("StopTimerEvent", StopTimerEvent),
		new LuaMethod("ResumeTimerEvent", ResumeTimerEvent),
		new LuaMethod("New", _Createcom_junfine_simpleframework_manager_TimerManager),
		new LuaMethod("GetClassType", GetClassType),
		new LuaMethod("__eq", Lua_Eq),
	};

	static LuaField[] fields = new LuaField[]
	{
		new LuaField("Interval", get_Interval, set_Interval),
	};

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _Createcom_junfine_simpleframework_manager_TimerManager(IntPtr L)
	{
		LuaDLL.luaL_error(L, "com.junfine.simpleframework.manager.TimerManager class does not have a constructor function");
		return 0;
	}

	static Type classType = typeof(com.junfine.simpleframework.manager.TimerManager);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);

		return 1;
	}

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "com.junfine.simpleframework.manager.TimerManager", typeof(com.junfine.simpleframework.manager.TimerManager), regs, fields, typeof(MonoBehaviour));
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Interval(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		com.junfine.simpleframework.manager.TimerManager obj = (com.junfine.simpleframework.manager.TimerManager)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name Interval");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index Interval on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.Interval);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Interval(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		com.junfine.simpleframework.manager.TimerManager obj = (com.junfine.simpleframework.manager.TimerManager)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name Interval");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index Interval on a nil value");
			}
		}

		obj.Interval = (float)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int StartTimer(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		com.junfine.simpleframework.manager.TimerManager obj = (com.junfine.simpleframework.manager.TimerManager)LuaScriptMgr.GetUnityObject(L, 1, typeof(com.junfine.simpleframework.manager.TimerManager));
		float arg0 = (float)LuaScriptMgr.GetNumber(L, 2);
		obj.StartTimer(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int StopTimer(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		com.junfine.simpleframework.manager.TimerManager obj = (com.junfine.simpleframework.manager.TimerManager)LuaScriptMgr.GetUnityObject(L, 1, typeof(com.junfine.simpleframework.manager.TimerManager));
		obj.StopTimer();
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddTimerEvent(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		com.junfine.simpleframework.manager.TimerManager obj = (com.junfine.simpleframework.manager.TimerManager)LuaScriptMgr.GetUnityObject(L, 1, typeof(com.junfine.simpleframework.manager.TimerManager));
		com.junfine.simpleframework.manager.TimerInfo arg0 = (com.junfine.simpleframework.manager.TimerInfo)LuaScriptMgr.GetNetObject(L, 2, typeof(com.junfine.simpleframework.manager.TimerInfo));
		obj.AddTimerEvent(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RemoveTimerEvent(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		com.junfine.simpleframework.manager.TimerManager obj = (com.junfine.simpleframework.manager.TimerManager)LuaScriptMgr.GetUnityObject(L, 1, typeof(com.junfine.simpleframework.manager.TimerManager));
		com.junfine.simpleframework.manager.TimerInfo arg0 = (com.junfine.simpleframework.manager.TimerInfo)LuaScriptMgr.GetNetObject(L, 2, typeof(com.junfine.simpleframework.manager.TimerInfo));
		obj.RemoveTimerEvent(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int StopTimerEvent(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		com.junfine.simpleframework.manager.TimerManager obj = (com.junfine.simpleframework.manager.TimerManager)LuaScriptMgr.GetUnityObject(L, 1, typeof(com.junfine.simpleframework.manager.TimerManager));
		com.junfine.simpleframework.manager.TimerInfo arg0 = (com.junfine.simpleframework.manager.TimerInfo)LuaScriptMgr.GetNetObject(L, 2, typeof(com.junfine.simpleframework.manager.TimerInfo));
		obj.StopTimerEvent(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ResumeTimerEvent(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		com.junfine.simpleframework.manager.TimerManager obj = (com.junfine.simpleframework.manager.TimerManager)LuaScriptMgr.GetUnityObject(L, 1, typeof(com.junfine.simpleframework.manager.TimerManager));
		com.junfine.simpleframework.manager.TimerInfo arg0 = (com.junfine.simpleframework.manager.TimerInfo)LuaScriptMgr.GetNetObject(L, 2, typeof(com.junfine.simpleframework.manager.TimerInfo));
		obj.ResumeTimerEvent(arg0);
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

