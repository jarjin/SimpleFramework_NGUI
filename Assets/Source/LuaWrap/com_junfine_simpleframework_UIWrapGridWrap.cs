using System;
using com.junfine.simpleframework;
using UnityEngine;
using LuaInterface;
using Object = UnityEngine.Object;

public class com_junfine_simpleframework_UIWrapGridWrap
{
	public static LuaMethod[] regs = new LuaMethod[]
	{
		new LuaMethod("InitGrid", InitGrid),
		new LuaMethod("New", _Createcom_junfine_simpleframework_UIWrapGrid),
		new LuaMethod("GetClassType", GetClassType),
		new LuaMethod("__eq", Lua_Eq),
	};

	static LuaField[] fields = new LuaField[]
	{
	};

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _Createcom_junfine_simpleframework_UIWrapGrid(IntPtr L)
	{
		LuaDLL.luaL_error(L, "com.junfine.simpleframework.UIWrapGrid class does not have a constructor function");
		return 0;
	}

	static Type classType = typeof(com.junfine.simpleframework.UIWrapGrid);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);

		return 1;
	}

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "com.junfine.simpleframework.UIWrapGrid", typeof(com.junfine.simpleframework.UIWrapGrid), regs, fields, typeof(MonoBehaviour));
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int InitGrid(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		com.junfine.simpleframework.UIWrapGrid obj = (com.junfine.simpleframework.UIWrapGrid)LuaScriptMgr.GetUnityObject(L, 1, typeof(com.junfine.simpleframework.UIWrapGrid));
		obj.InitGrid();
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

