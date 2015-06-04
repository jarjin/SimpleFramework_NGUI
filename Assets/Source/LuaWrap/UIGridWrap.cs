using System;
using UnityEngine;
using System.Collections.Generic;
using LuaInterface;
using Object = UnityEngine.Object;

public class UIGridWrap
{
	public static LuaMethod[] regs = new LuaMethod[]
	{
		new LuaMethod("GetChildList", GetChildList),
		new LuaMethod("GetChild", GetChild),
		new LuaMethod("GetIndex", GetIndex),
		new LuaMethod("AddChild", AddChild),
		new LuaMethod("RemoveChild", RemoveChild),
		new LuaMethod("SortByName", SortByName),
		new LuaMethod("SortHorizontal", SortHorizontal),
		new LuaMethod("SortVertical", SortVertical),
		new LuaMethod("Reposition", Reposition),
		new LuaMethod("ConstrainWithinPanel", ConstrainWithinPanel),
		new LuaMethod("New", _CreateUIGrid),
		new LuaMethod("GetClassType", GetClassType),
		new LuaMethod("__eq", Lua_Eq),
	};

	static LuaField[] fields = new LuaField[]
	{
		new LuaField("arrangement", get_arrangement, set_arrangement),
		new LuaField("sorting", get_sorting, set_sorting),
		new LuaField("pivot", get_pivot, set_pivot),
		new LuaField("maxPerLine", get_maxPerLine, set_maxPerLine),
		new LuaField("cellWidth", get_cellWidth, set_cellWidth),
		new LuaField("cellHeight", get_cellHeight, set_cellHeight),
		new LuaField("animateSmoothly", get_animateSmoothly, set_animateSmoothly),
		new LuaField("hideInactive", get_hideInactive, set_hideInactive),
		new LuaField("keepWithinPanel", get_keepWithinPanel, set_keepWithinPanel),
		new LuaField("onReposition", get_onReposition, set_onReposition),
		new LuaField("onCustomSort", get_onCustomSort, set_onCustomSort),
		new LuaField("repositionNow", null, set_repositionNow),
	};

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateUIGrid(IntPtr L)
	{
		LuaDLL.luaL_error(L, "UIGrid class does not have a constructor function");
		return 0;
	}

	static Type classType = typeof(UIGrid);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);

		return 1;
	}

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "UIGrid", typeof(UIGrid), regs, fields, typeof(UIWidgetContainer));
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_arrangement(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIGrid obj = (UIGrid)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name arrangement");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index arrangement on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.arrangement);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_sorting(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIGrid obj = (UIGrid)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name sorting");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index sorting on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.sorting);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_pivot(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIGrid obj = (UIGrid)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name pivot");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index pivot on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.pivot);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_maxPerLine(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIGrid obj = (UIGrid)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name maxPerLine");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index maxPerLine on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.maxPerLine);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_cellWidth(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIGrid obj = (UIGrid)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name cellWidth");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index cellWidth on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.cellWidth);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_cellHeight(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIGrid obj = (UIGrid)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name cellHeight");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index cellHeight on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.cellHeight);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_animateSmoothly(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIGrid obj = (UIGrid)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name animateSmoothly");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index animateSmoothly on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.animateSmoothly);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_hideInactive(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIGrid obj = (UIGrid)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name hideInactive");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index hideInactive on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.hideInactive);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_keepWithinPanel(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIGrid obj = (UIGrid)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name keepWithinPanel");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index keepWithinPanel on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.keepWithinPanel);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onReposition(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIGrid obj = (UIGrid)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onReposition");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onReposition on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.onReposition);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onCustomSort(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIGrid obj = (UIGrid)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onCustomSort");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onCustomSort on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.onCustomSort);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_arrangement(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIGrid obj = (UIGrid)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name arrangement");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index arrangement on a nil value");
			}
		}

		obj.arrangement = (UIGrid.Arrangement)LuaScriptMgr.GetNetObject(L, 3, typeof(UIGrid.Arrangement));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_sorting(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIGrid obj = (UIGrid)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name sorting");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index sorting on a nil value");
			}
		}

		obj.sorting = (UIGrid.Sorting)LuaScriptMgr.GetNetObject(L, 3, typeof(UIGrid.Sorting));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_pivot(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIGrid obj = (UIGrid)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name pivot");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index pivot on a nil value");
			}
		}

		obj.pivot = (UIWidget.Pivot)LuaScriptMgr.GetNetObject(L, 3, typeof(UIWidget.Pivot));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_maxPerLine(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIGrid obj = (UIGrid)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name maxPerLine");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index maxPerLine on a nil value");
			}
		}

		obj.maxPerLine = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_cellWidth(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIGrid obj = (UIGrid)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name cellWidth");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index cellWidth on a nil value");
			}
		}

		obj.cellWidth = (float)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_cellHeight(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIGrid obj = (UIGrid)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name cellHeight");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index cellHeight on a nil value");
			}
		}

		obj.cellHeight = (float)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_animateSmoothly(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIGrid obj = (UIGrid)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name animateSmoothly");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index animateSmoothly on a nil value");
			}
		}

		obj.animateSmoothly = LuaScriptMgr.GetBoolean(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_hideInactive(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIGrid obj = (UIGrid)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name hideInactive");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index hideInactive on a nil value");
			}
		}

		obj.hideInactive = LuaScriptMgr.GetBoolean(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_keepWithinPanel(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIGrid obj = (UIGrid)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name keepWithinPanel");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index keepWithinPanel on a nil value");
			}
		}

		obj.keepWithinPanel = LuaScriptMgr.GetBoolean(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onReposition(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIGrid obj = (UIGrid)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onReposition");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onReposition on a nil value");
			}
		}

		LuaTypes type = LuaDLL.lua_type(L, 3);

		if (type != LuaTypes.LUA_TFUNCTION)
		{
			obj.onReposition = (UIGrid.OnReposition)LuaScriptMgr.GetNetObject(L, 3, typeof(UIGrid.OnReposition));
		}
		else
		{
			LuaFunction func = LuaScriptMgr.GetLuaFunction(L, 3);
			obj.onReposition = () =>
			{
				func.Call();
			};
		}
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onCustomSort(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIGrid obj = (UIGrid)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onCustomSort");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onCustomSort on a nil value");
			}
		}

		LuaTypes type = LuaDLL.lua_type(L, 3);

		if (type != LuaTypes.LUA_TFUNCTION)
		{
			obj.onCustomSort = (Comparison<Transform>)LuaScriptMgr.GetNetObject(L, 3, typeof(Comparison<Transform>));
		}
		else
		{
			LuaFunction func = LuaScriptMgr.GetLuaFunction(L, 3);
			obj.onCustomSort = (arg0, arg1) =>
			{
				int top = func.BeginPCall();
				LuaScriptMgr.Push(L, arg0);
				LuaScriptMgr.Push(L, arg1);
				func.PCall(top, 2);
				object[] objs = func.EndPCall(top);
				return (int)objs[0];
			};
		}
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_repositionNow(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIGrid obj = (UIGrid)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name repositionNow");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index repositionNow on a nil value");
			}
		}

		obj.repositionNow = LuaScriptMgr.GetBoolean(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetChildList(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		UIGrid obj = (UIGrid)LuaScriptMgr.GetUnityObject(L, 1, typeof(UIGrid));
		List<Transform> o = obj.GetChildList();
		LuaScriptMgr.PushObject(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetChild(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		UIGrid obj = (UIGrid)LuaScriptMgr.GetUnityObject(L, 1, typeof(UIGrid));
		int arg0 = (int)LuaScriptMgr.GetNumber(L, 2);
		Transform o = obj.GetChild(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetIndex(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		UIGrid obj = (UIGrid)LuaScriptMgr.GetUnityObject(L, 1, typeof(UIGrid));
		Transform arg0 = (Transform)LuaScriptMgr.GetUnityObject(L, 2, typeof(Transform));
		int o = obj.GetIndex(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddChild(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);
		if (count == 2)
		{
			UIGrid obj = (UIGrid)LuaScriptMgr.GetUnityObject(L, 1, typeof(UIGrid));
			Transform arg0 = (Transform)LuaScriptMgr.GetUnityObject(L, 2, typeof(Transform));
			obj.AddChild(arg0);
			return 0;
		}
		else if (count == 3)
		{
			UIGrid obj = (UIGrid)LuaScriptMgr.GetUnityObject(L, 1, typeof(UIGrid));
			Transform arg0 = (Transform)LuaScriptMgr.GetUnityObject(L, 2, typeof(Transform));
			bool arg1 = LuaScriptMgr.GetBoolean(L, 3);
			obj.AddChild(arg0,arg1);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: UIGrid.AddChild");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RemoveChild(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		UIGrid obj = (UIGrid)LuaScriptMgr.GetUnityObject(L, 1, typeof(UIGrid));
		Transform arg0 = (Transform)LuaScriptMgr.GetUnityObject(L, 2, typeof(Transform));
		bool o = obj.RemoveChild(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SortByName(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		Transform arg0 = (Transform)LuaScriptMgr.GetUnityObject(L, 1, typeof(Transform));
		Transform arg1 = (Transform)LuaScriptMgr.GetUnityObject(L, 2, typeof(Transform));
		int o = UIGrid.SortByName(arg0,arg1);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SortHorizontal(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		Transform arg0 = (Transform)LuaScriptMgr.GetUnityObject(L, 1, typeof(Transform));
		Transform arg1 = (Transform)LuaScriptMgr.GetUnityObject(L, 2, typeof(Transform));
		int o = UIGrid.SortHorizontal(arg0,arg1);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SortVertical(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		Transform arg0 = (Transform)LuaScriptMgr.GetUnityObject(L, 1, typeof(Transform));
		Transform arg1 = (Transform)LuaScriptMgr.GetUnityObject(L, 2, typeof(Transform));
		int o = UIGrid.SortVertical(arg0,arg1);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Reposition(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		UIGrid obj = (UIGrid)LuaScriptMgr.GetUnityObject(L, 1, typeof(UIGrid));
		obj.Reposition();
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ConstrainWithinPanel(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		UIGrid obj = (UIGrid)LuaScriptMgr.GetUnityObject(L, 1, typeof(UIGrid));
		obj.ConstrainWithinPanel();
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

