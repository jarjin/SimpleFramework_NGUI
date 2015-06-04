using System;
using com.junfine.simpleframework;
using UnityEngine;
using LuaInterface;

public class com_junfine_simpleframework_ConstWrap
{
	public static LuaMethod[] regs = new LuaMethod[]
	{
		new LuaMethod("New", _Createcom_junfine_simpleframework_Const),
		new LuaMethod("GetClassType", GetClassType),
	};

	static LuaField[] fields = new LuaField[]
	{
		new LuaField("DebugMode", get_DebugMode, set_DebugMode),
		new LuaField("UpdateMode", get_UpdateMode, set_UpdateMode),
		new LuaField("UsePbc", get_UsePbc, set_UsePbc),
		new LuaField("UseLpeg", get_UseLpeg, set_UseLpeg),
		new LuaField("UsePbLua", get_UsePbLua, set_UsePbLua),
		new LuaField("UseCJson", get_UseCJson, set_UseCJson),
		new LuaField("UseSQLite", get_UseSQLite, set_UseSQLite),
		new LuaField("TimerInterval", get_TimerInterval, set_TimerInterval),
		new LuaField("GameFrameRate", get_GameFrameRate, set_GameFrameRate),
		new LuaField("luaScripts", get_luaScripts, set_luaScripts),
		new LuaField("UserId", get_UserId, set_UserId),
		new LuaField("AppName", get_AppName, set_AppName),
		new LuaField("AppPrefix", get_AppPrefix, set_AppPrefix),
		new LuaField("WebUrl", get_WebUrl, set_WebUrl),
		new LuaField("SocketPort", get_SocketPort, set_SocketPort),
		new LuaField("SocketAddress", get_SocketAddress, set_SocketAddress),
	};

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _Createcom_junfine_simpleframework_Const(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 0)
		{
			com.junfine.simpleframework.Const obj = new com.junfine.simpleframework.Const();
			LuaScriptMgr.PushObject(L, obj);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: com.junfine.simpleframework.Const.New");
		}

		return 0;
	}

	static Type classType = typeof(com.junfine.simpleframework.Const);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);

		return 1;
	}

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "com.junfine.simpleframework.Const", typeof(com.junfine.simpleframework.Const), regs, fields, typeof(object));
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_DebugMode(IntPtr L)
	{
		LuaScriptMgr.Push(L, com.junfine.simpleframework.Const.DebugMode);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_UpdateMode(IntPtr L)
	{
		LuaScriptMgr.Push(L, com.junfine.simpleframework.Const.UpdateMode);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_UsePbc(IntPtr L)
	{
		LuaScriptMgr.Push(L, com.junfine.simpleframework.Const.UsePbc);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_UseLpeg(IntPtr L)
	{
		LuaScriptMgr.Push(L, com.junfine.simpleframework.Const.UseLpeg);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_UsePbLua(IntPtr L)
	{
		LuaScriptMgr.Push(L, com.junfine.simpleframework.Const.UsePbLua);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_UseCJson(IntPtr L)
	{
		LuaScriptMgr.Push(L, com.junfine.simpleframework.Const.UseCJson);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_UseSQLite(IntPtr L)
	{
		LuaScriptMgr.Push(L, com.junfine.simpleframework.Const.UseSQLite);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_TimerInterval(IntPtr L)
	{
		LuaScriptMgr.Push(L, com.junfine.simpleframework.Const.TimerInterval);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_GameFrameRate(IntPtr L)
	{
		LuaScriptMgr.Push(L, com.junfine.simpleframework.Const.GameFrameRate);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_luaScripts(IntPtr L)
	{
		LuaScriptMgr.PushArray(L, com.junfine.simpleframework.Const.luaScripts);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_UserId(IntPtr L)
	{
		LuaScriptMgr.Push(L, com.junfine.simpleframework.Const.UserId);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_AppName(IntPtr L)
	{
		LuaScriptMgr.Push(L, com.junfine.simpleframework.Const.AppName);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_AppPrefix(IntPtr L)
	{
		LuaScriptMgr.Push(L, com.junfine.simpleframework.Const.AppPrefix);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_WebUrl(IntPtr L)
	{
		LuaScriptMgr.Push(L, com.junfine.simpleframework.Const.WebUrl);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_SocketPort(IntPtr L)
	{
		LuaScriptMgr.Push(L, com.junfine.simpleframework.Const.SocketPort);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_SocketAddress(IntPtr L)
	{
		LuaScriptMgr.Push(L, com.junfine.simpleframework.Const.SocketAddress);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_DebugMode(IntPtr L)
	{
		com.junfine.simpleframework.Const.DebugMode = LuaScriptMgr.GetBoolean(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_UpdateMode(IntPtr L)
	{
		com.junfine.simpleframework.Const.UpdateMode = LuaScriptMgr.GetBoolean(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_UsePbc(IntPtr L)
	{
		com.junfine.simpleframework.Const.UsePbc = LuaScriptMgr.GetBoolean(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_UseLpeg(IntPtr L)
	{
		com.junfine.simpleframework.Const.UseLpeg = LuaScriptMgr.GetBoolean(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_UsePbLua(IntPtr L)
	{
		com.junfine.simpleframework.Const.UsePbLua = LuaScriptMgr.GetBoolean(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_UseCJson(IntPtr L)
	{
		com.junfine.simpleframework.Const.UseCJson = LuaScriptMgr.GetBoolean(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_UseSQLite(IntPtr L)
	{
		com.junfine.simpleframework.Const.UseSQLite = LuaScriptMgr.GetBoolean(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_TimerInterval(IntPtr L)
	{
		com.junfine.simpleframework.Const.TimerInterval = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_GameFrameRate(IntPtr L)
	{
		com.junfine.simpleframework.Const.GameFrameRate = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_luaScripts(IntPtr L)
	{
		com.junfine.simpleframework.Const.luaScripts = (TextAsset[])LuaScriptMgr.GetNetObject(L, 3, typeof(TextAsset[]));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_UserId(IntPtr L)
	{
		com.junfine.simpleframework.Const.UserId = LuaScriptMgr.GetString(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_AppName(IntPtr L)
	{
		com.junfine.simpleframework.Const.AppName = LuaScriptMgr.GetString(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_AppPrefix(IntPtr L)
	{
		com.junfine.simpleframework.Const.AppPrefix = LuaScriptMgr.GetString(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_WebUrl(IntPtr L)
	{
		com.junfine.simpleframework.Const.WebUrl = LuaScriptMgr.GetString(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_SocketPort(IntPtr L)
	{
		com.junfine.simpleframework.Const.SocketPort = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_SocketAddress(IntPtr L)
	{
		com.junfine.simpleframework.Const.SocketAddress = LuaScriptMgr.GetString(L, 3);
		return 0;
	}
}

