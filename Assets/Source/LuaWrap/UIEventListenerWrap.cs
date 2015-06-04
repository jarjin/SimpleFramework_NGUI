using System;
using UnityEngine;
using LuaInterface;
using Object = UnityEngine.Object;

public class UIEventListenerWrap
{
	public static LuaMethod[] regs = new LuaMethod[]
	{
		new LuaMethod("Get", Get),
		new LuaMethod("New", _CreateUIEventListener),
		new LuaMethod("GetClassType", GetClassType),
		new LuaMethod("__eq", Lua_Eq),
	};

	static LuaField[] fields = new LuaField[]
	{
		new LuaField("parameter", get_parameter, set_parameter),
		new LuaField("onSubmit", get_onSubmit, set_onSubmit),
		new LuaField("onClick", get_onClick, set_onClick),
		new LuaField("onDoubleClick", get_onDoubleClick, set_onDoubleClick),
		new LuaField("onHover", get_onHover, set_onHover),
		new LuaField("onPress", get_onPress, set_onPress),
		new LuaField("onSelect", get_onSelect, set_onSelect),
		new LuaField("onScroll", get_onScroll, set_onScroll),
		new LuaField("onDragStart", get_onDragStart, set_onDragStart),
		new LuaField("onDrag", get_onDrag, set_onDrag),
		new LuaField("onDragOver", get_onDragOver, set_onDragOver),
		new LuaField("onDragOut", get_onDragOut, set_onDragOut),
		new LuaField("onDragEnd", get_onDragEnd, set_onDragEnd),
		new LuaField("onDrop", get_onDrop, set_onDrop),
		new LuaField("onKey", get_onKey, set_onKey),
		new LuaField("onTooltip", get_onTooltip, set_onTooltip),
	};

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateUIEventListener(IntPtr L)
	{
		LuaDLL.luaL_error(L, "UIEventListener class does not have a constructor function");
		return 0;
	}

	static Type classType = typeof(UIEventListener);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);

		return 1;
	}

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "UIEventListener", typeof(UIEventListener), regs, fields, typeof(MonoBehaviour));
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_parameter(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIEventListener obj = (UIEventListener)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name parameter");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index parameter on a nil value");
			}
		}

		LuaScriptMgr.PushVarObject(L, obj.parameter);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onSubmit(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIEventListener obj = (UIEventListener)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onSubmit");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onSubmit on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.onSubmit);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onClick(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIEventListener obj = (UIEventListener)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onClick");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onClick on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.onClick);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onDoubleClick(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIEventListener obj = (UIEventListener)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onDoubleClick");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onDoubleClick on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.onDoubleClick);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onHover(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIEventListener obj = (UIEventListener)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onHover");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onHover on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.onHover);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onPress(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIEventListener obj = (UIEventListener)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onPress");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onPress on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.onPress);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onSelect(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIEventListener obj = (UIEventListener)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onSelect");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onSelect on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.onSelect);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onScroll(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIEventListener obj = (UIEventListener)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onScroll");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onScroll on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.onScroll);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onDragStart(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIEventListener obj = (UIEventListener)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onDragStart");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onDragStart on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.onDragStart);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onDrag(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIEventListener obj = (UIEventListener)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onDrag");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onDrag on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.onDrag);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onDragOver(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIEventListener obj = (UIEventListener)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onDragOver");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onDragOver on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.onDragOver);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onDragOut(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIEventListener obj = (UIEventListener)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onDragOut");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onDragOut on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.onDragOut);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onDragEnd(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIEventListener obj = (UIEventListener)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onDragEnd");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onDragEnd on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.onDragEnd);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onDrop(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIEventListener obj = (UIEventListener)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onDrop");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onDrop on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.onDrop);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onKey(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIEventListener obj = (UIEventListener)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onKey");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onKey on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.onKey);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onTooltip(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIEventListener obj = (UIEventListener)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onTooltip");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onTooltip on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.onTooltip);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_parameter(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIEventListener obj = (UIEventListener)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name parameter");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index parameter on a nil value");
			}
		}

		obj.parameter = LuaScriptMgr.GetVarObject(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onSubmit(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIEventListener obj = (UIEventListener)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onSubmit");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onSubmit on a nil value");
			}
		}

		LuaTypes type = LuaDLL.lua_type(L, 3);

		if (type != LuaTypes.LUA_TFUNCTION)
		{
			obj.onSubmit = (UIEventListener.VoidDelegate)LuaScriptMgr.GetNetObject(L, 3, typeof(UIEventListener.VoidDelegate));
		}
		else
		{
			LuaFunction func = LuaScriptMgr.GetLuaFunction(L, 3);
			obj.onSubmit = (arg0) =>
			{
				int top = func.BeginPCall();
				LuaScriptMgr.Push(L, arg0);
				func.PCall(top, 1);
				func.EndPCall();
			};
		}
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onClick(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIEventListener obj = (UIEventListener)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onClick");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onClick on a nil value");
			}
		}

		LuaTypes type = LuaDLL.lua_type(L, 3);

		if (type != LuaTypes.LUA_TFUNCTION)
		{
			obj.onClick = (UIEventListener.VoidDelegate)LuaScriptMgr.GetNetObject(L, 3, typeof(UIEventListener.VoidDelegate));
		}
		else
		{
			LuaFunction func = LuaScriptMgr.GetLuaFunction(L, 3);
			obj.onClick = (arg0) =>
			{
				int top = func.BeginPCall();
				LuaScriptMgr.Push(L, arg0);
				func.PCall(top, 1);
				func.EndPCall();
			};
		}
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onDoubleClick(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIEventListener obj = (UIEventListener)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onDoubleClick");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onDoubleClick on a nil value");
			}
		}

		LuaTypes type = LuaDLL.lua_type(L, 3);

		if (type != LuaTypes.LUA_TFUNCTION)
		{
			obj.onDoubleClick = (UIEventListener.VoidDelegate)LuaScriptMgr.GetNetObject(L, 3, typeof(UIEventListener.VoidDelegate));
		}
		else
		{
			LuaFunction func = LuaScriptMgr.GetLuaFunction(L, 3);
			obj.onDoubleClick = (arg0) =>
			{
				int top = func.BeginPCall();
				LuaScriptMgr.Push(L, arg0);
				func.PCall(top, 1);
				func.EndPCall();
			};
		}
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onHover(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIEventListener obj = (UIEventListener)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onHover");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onHover on a nil value");
			}
		}

		LuaTypes type = LuaDLL.lua_type(L, 3);

		if (type != LuaTypes.LUA_TFUNCTION)
		{
			obj.onHover = (UIEventListener.BoolDelegate)LuaScriptMgr.GetNetObject(L, 3, typeof(UIEventListener.BoolDelegate));
		}
		else
		{
			LuaFunction func = LuaScriptMgr.GetLuaFunction(L, 3);
			obj.onHover = (arg0, arg1) =>
			{
				int top = func.BeginPCall();
				LuaScriptMgr.Push(L, arg0);
				LuaScriptMgr.Push(L, arg1);
				func.PCall(top, 2);
				func.EndPCall();
			};
		}
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onPress(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIEventListener obj = (UIEventListener)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onPress");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onPress on a nil value");
			}
		}

		LuaTypes type = LuaDLL.lua_type(L, 3);

		if (type != LuaTypes.LUA_TFUNCTION)
		{
			obj.onPress = (UIEventListener.BoolDelegate)LuaScriptMgr.GetNetObject(L, 3, typeof(UIEventListener.BoolDelegate));
		}
		else
		{
			LuaFunction func = LuaScriptMgr.GetLuaFunction(L, 3);
			obj.onPress = (arg0, arg1) =>
			{
				int top = func.BeginPCall();
				LuaScriptMgr.Push(L, arg0);
				LuaScriptMgr.Push(L, arg1);
				func.PCall(top, 2);
				func.EndPCall();
			};
		}
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onSelect(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIEventListener obj = (UIEventListener)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onSelect");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onSelect on a nil value");
			}
		}

		LuaTypes type = LuaDLL.lua_type(L, 3);

		if (type != LuaTypes.LUA_TFUNCTION)
		{
			obj.onSelect = (UIEventListener.BoolDelegate)LuaScriptMgr.GetNetObject(L, 3, typeof(UIEventListener.BoolDelegate));
		}
		else
		{
			LuaFunction func = LuaScriptMgr.GetLuaFunction(L, 3);
			obj.onSelect = (arg0, arg1) =>
			{
				int top = func.BeginPCall();
				LuaScriptMgr.Push(L, arg0);
				LuaScriptMgr.Push(L, arg1);
				func.PCall(top, 2);
				func.EndPCall();
			};
		}
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onScroll(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIEventListener obj = (UIEventListener)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onScroll");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onScroll on a nil value");
			}
		}

		LuaTypes type = LuaDLL.lua_type(L, 3);

		if (type != LuaTypes.LUA_TFUNCTION)
		{
			obj.onScroll = (UIEventListener.FloatDelegate)LuaScriptMgr.GetNetObject(L, 3, typeof(UIEventListener.FloatDelegate));
		}
		else
		{
			LuaFunction func = LuaScriptMgr.GetLuaFunction(L, 3);
			obj.onScroll = (arg0, arg1) =>
			{
				int top = func.BeginPCall();
				LuaScriptMgr.Push(L, arg0);
				LuaScriptMgr.Push(L, arg1);
				func.PCall(top, 2);
				func.EndPCall();
			};
		}
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onDragStart(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIEventListener obj = (UIEventListener)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onDragStart");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onDragStart on a nil value");
			}
		}

		LuaTypes type = LuaDLL.lua_type(L, 3);

		if (type != LuaTypes.LUA_TFUNCTION)
		{
			obj.onDragStart = (UIEventListener.VoidDelegate)LuaScriptMgr.GetNetObject(L, 3, typeof(UIEventListener.VoidDelegate));
		}
		else
		{
			LuaFunction func = LuaScriptMgr.GetLuaFunction(L, 3);
			obj.onDragStart = (arg0) =>
			{
				int top = func.BeginPCall();
				LuaScriptMgr.Push(L, arg0);
				func.PCall(top, 1);
				func.EndPCall();
			};
		}
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onDrag(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIEventListener obj = (UIEventListener)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onDrag");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onDrag on a nil value");
			}
		}

		LuaTypes type = LuaDLL.lua_type(L, 3);

		if (type != LuaTypes.LUA_TFUNCTION)
		{
			obj.onDrag = (UIEventListener.VectorDelegate)LuaScriptMgr.GetNetObject(L, 3, typeof(UIEventListener.VectorDelegate));
		}
		else
		{
			LuaFunction func = LuaScriptMgr.GetLuaFunction(L, 3);
			obj.onDrag = (arg0, arg1) =>
			{
				int top = func.BeginPCall();
				LuaScriptMgr.Push(L, arg0);
				LuaScriptMgr.Push(L, arg1);
				func.PCall(top, 2);
				func.EndPCall();
			};
		}
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onDragOver(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIEventListener obj = (UIEventListener)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onDragOver");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onDragOver on a nil value");
			}
		}

		LuaTypes type = LuaDLL.lua_type(L, 3);

		if (type != LuaTypes.LUA_TFUNCTION)
		{
			obj.onDragOver = (UIEventListener.VoidDelegate)LuaScriptMgr.GetNetObject(L, 3, typeof(UIEventListener.VoidDelegate));
		}
		else
		{
			LuaFunction func = LuaScriptMgr.GetLuaFunction(L, 3);
			obj.onDragOver = (arg0) =>
			{
				int top = func.BeginPCall();
				LuaScriptMgr.Push(L, arg0);
				func.PCall(top, 1);
				func.EndPCall();
			};
		}
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onDragOut(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIEventListener obj = (UIEventListener)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onDragOut");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onDragOut on a nil value");
			}
		}

		LuaTypes type = LuaDLL.lua_type(L, 3);

		if (type != LuaTypes.LUA_TFUNCTION)
		{
			obj.onDragOut = (UIEventListener.VoidDelegate)LuaScriptMgr.GetNetObject(L, 3, typeof(UIEventListener.VoidDelegate));
		}
		else
		{
			LuaFunction func = LuaScriptMgr.GetLuaFunction(L, 3);
			obj.onDragOut = (arg0) =>
			{
				int top = func.BeginPCall();
				LuaScriptMgr.Push(L, arg0);
				func.PCall(top, 1);
				func.EndPCall();
			};
		}
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onDragEnd(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIEventListener obj = (UIEventListener)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onDragEnd");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onDragEnd on a nil value");
			}
		}

		LuaTypes type = LuaDLL.lua_type(L, 3);

		if (type != LuaTypes.LUA_TFUNCTION)
		{
			obj.onDragEnd = (UIEventListener.VoidDelegate)LuaScriptMgr.GetNetObject(L, 3, typeof(UIEventListener.VoidDelegate));
		}
		else
		{
			LuaFunction func = LuaScriptMgr.GetLuaFunction(L, 3);
			obj.onDragEnd = (arg0) =>
			{
				int top = func.BeginPCall();
				LuaScriptMgr.Push(L, arg0);
				func.PCall(top, 1);
				func.EndPCall();
			};
		}
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onDrop(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIEventListener obj = (UIEventListener)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onDrop");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onDrop on a nil value");
			}
		}

		LuaTypes type = LuaDLL.lua_type(L, 3);

		if (type != LuaTypes.LUA_TFUNCTION)
		{
			obj.onDrop = (UIEventListener.ObjectDelegate)LuaScriptMgr.GetNetObject(L, 3, typeof(UIEventListener.ObjectDelegate));
		}
		else
		{
			LuaFunction func = LuaScriptMgr.GetLuaFunction(L, 3);
			obj.onDrop = (arg0, arg1) =>
			{
				int top = func.BeginPCall();
				LuaScriptMgr.Push(L, arg0);
				LuaScriptMgr.Push(L, arg1);
				func.PCall(top, 2);
				func.EndPCall();
			};
		}
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onKey(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIEventListener obj = (UIEventListener)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onKey");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onKey on a nil value");
			}
		}

		LuaTypes type = LuaDLL.lua_type(L, 3);

		if (type != LuaTypes.LUA_TFUNCTION)
		{
			obj.onKey = (UIEventListener.KeyCodeDelegate)LuaScriptMgr.GetNetObject(L, 3, typeof(UIEventListener.KeyCodeDelegate));
		}
		else
		{
			LuaFunction func = LuaScriptMgr.GetLuaFunction(L, 3);
			obj.onKey = (arg0, arg1) =>
			{
				int top = func.BeginPCall();
				LuaScriptMgr.Push(L, arg0);
				LuaScriptMgr.Push(L, arg1);
				func.PCall(top, 2);
				func.EndPCall();
			};
		}
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onTooltip(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIEventListener obj = (UIEventListener)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onTooltip");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onTooltip on a nil value");
			}
		}

		LuaTypes type = LuaDLL.lua_type(L, 3);

		if (type != LuaTypes.LUA_TFUNCTION)
		{
			obj.onTooltip = (UIEventListener.BoolDelegate)LuaScriptMgr.GetNetObject(L, 3, typeof(UIEventListener.BoolDelegate));
		}
		else
		{
			LuaFunction func = LuaScriptMgr.GetLuaFunction(L, 3);
			obj.onTooltip = (arg0, arg1) =>
			{
				int top = func.BeginPCall();
				LuaScriptMgr.Push(L, arg0);
				LuaScriptMgr.Push(L, arg1);
				func.PCall(top, 2);
				func.EndPCall();
			};
		}
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Get(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 1, typeof(GameObject));
		UIEventListener o = UIEventListener.Get(arg0);
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

