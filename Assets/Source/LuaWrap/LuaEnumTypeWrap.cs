using System;
using LuaInterface;

public class LuaEnumTypeWrap
{
	static LuaMethod[] enums = new LuaMethod[]
	{
		new LuaMethod("AAA", GetAAA),
		new LuaMethod("BBB", GetBBB),
		new LuaMethod("CCC", GetCCC),
		new LuaMethod("DDD", GetDDD),
		new LuaMethod("IntToEnum", IntToEnum),
	};

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "LuaEnumType", typeof(LuaEnumType), enums);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetAAA(IntPtr L)
	{
		LuaScriptMgr.Push(L, LuaEnumType.AAA);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetBBB(IntPtr L)
	{
		LuaScriptMgr.Push(L, LuaEnumType.BBB);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetCCC(IntPtr L)
	{
		LuaScriptMgr.Push(L, LuaEnumType.CCC);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetDDD(IntPtr L)
	{
		LuaScriptMgr.Push(L, LuaEnumType.DDD);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		LuaEnumType o = (LuaEnumType)arg0;
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

