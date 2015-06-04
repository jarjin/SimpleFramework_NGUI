using System;
using System.Collections.Generic;
using UnityEngine;
using LuaInterface;
using Object = UnityEngine.Object;

public class UIPanelWrap
{
	public static LuaMethod[] regs = new LuaMethod[]
	{
		new LuaMethod("CompareFunc", CompareFunc),
		new LuaMethod("GetSides", GetSides),
		new LuaMethod("Invalidate", Invalidate),
		new LuaMethod("CalculateFinalAlpha", CalculateFinalAlpha),
		new LuaMethod("SetRect", SetRect),
		new LuaMethod("IsVisible", IsVisible),
		new LuaMethod("Affects", Affects),
		new LuaMethod("RebuildAllDrawCalls", RebuildAllDrawCalls),
		new LuaMethod("SetDirty", SetDirty),
		new LuaMethod("ParentHasChanged", ParentHasChanged),
		new LuaMethod("SortWidgets", SortWidgets),
		new LuaMethod("FindDrawCall", FindDrawCall),
		new LuaMethod("AddWidget", AddWidget),
		new LuaMethod("RemoveWidget", RemoveWidget),
		new LuaMethod("Refresh", Refresh),
		new LuaMethod("CalculateConstrainOffset", CalculateConstrainOffset),
		new LuaMethod("ConstrainTargetToBounds", ConstrainTargetToBounds),
		new LuaMethod("Find", Find),
		new LuaMethod("GetWindowSize", GetWindowSize),
		new LuaMethod("GetViewSize", GetViewSize),
		new LuaMethod("New", _CreateUIPanel),
		new LuaMethod("GetClassType", GetClassType),
		new LuaMethod("__eq", Lua_Eq),
	};

	static LuaField[] fields = new LuaField[]
	{
		new LuaField("list", get_list, set_list),
		new LuaField("onGeometryUpdated", get_onGeometryUpdated, set_onGeometryUpdated),
		new LuaField("showInPanelTool", get_showInPanelTool, set_showInPanelTool),
		new LuaField("generateNormals", get_generateNormals, set_generateNormals),
		new LuaField("widgetsAreStatic", get_widgetsAreStatic, set_widgetsAreStatic),
		new LuaField("cullWhileDragging", get_cullWhileDragging, set_cullWhileDragging),
		new LuaField("alwaysOnScreen", get_alwaysOnScreen, set_alwaysOnScreen),
		new LuaField("anchorOffset", get_anchorOffset, set_anchorOffset),
		new LuaField("softBorderPadding", get_softBorderPadding, set_softBorderPadding),
		new LuaField("renderQueue", get_renderQueue, set_renderQueue),
		new LuaField("startingRenderQueue", get_startingRenderQueue, set_startingRenderQueue),
		new LuaField("widgets", get_widgets, set_widgets),
		new LuaField("drawCalls", get_drawCalls, set_drawCalls),
		new LuaField("worldToLocal", get_worldToLocal, set_worldToLocal),
		new LuaField("drawCallClipRange", get_drawCallClipRange, set_drawCallClipRange),
		new LuaField("onClipMove", get_onClipMove, set_onClipMove),
		new LuaField("nextUnusedDepth", get_nextUnusedDepth, null),
		new LuaField("canBeAnchored", get_canBeAnchored, null),
		new LuaField("alpha", get_alpha, set_alpha),
		new LuaField("depth", get_depth, set_depth),
		new LuaField("sortingOrder", get_sortingOrder, set_sortingOrder),
		new LuaField("width", get_width, null),
		new LuaField("height", get_height, null),
		new LuaField("halfPixelOffset", get_halfPixelOffset, null),
		new LuaField("usedForUI", get_usedForUI, null),
		new LuaField("drawCallOffset", get_drawCallOffset, null),
		new LuaField("clipping", get_clipping, set_clipping),
		new LuaField("parentPanel", get_parentPanel, null),
		new LuaField("clipCount", get_clipCount, null),
		new LuaField("hasClipping", get_hasClipping, null),
		new LuaField("hasCumulativeClipping", get_hasCumulativeClipping, null),
		new LuaField("clipOffset", get_clipOffset, set_clipOffset),
		new LuaField("clipTexture", get_clipTexture, set_clipTexture),
		new LuaField("baseClipRegion", get_baseClipRegion, set_baseClipRegion),
		new LuaField("finalClipRegion", get_finalClipRegion, null),
		new LuaField("clipSoftness", get_clipSoftness, set_clipSoftness),
		new LuaField("localCorners", get_localCorners, null),
		new LuaField("worldCorners", get_worldCorners, null),
	};

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateUIPanel(IntPtr L)
	{
		LuaDLL.luaL_error(L, "UIPanel class does not have a constructor function");
		return 0;
	}

	static Type classType = typeof(UIPanel);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);

		return 1;
	}

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "UIPanel", typeof(UIPanel), regs, fields, typeof(UIRect));
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_list(IntPtr L)
	{
		LuaScriptMgr.PushObject(L, UIPanel.list);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onGeometryUpdated(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIPanel obj = (UIPanel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onGeometryUpdated");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onGeometryUpdated on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.onGeometryUpdated);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_showInPanelTool(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIPanel obj = (UIPanel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name showInPanelTool");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index showInPanelTool on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.showInPanelTool);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_generateNormals(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIPanel obj = (UIPanel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name generateNormals");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index generateNormals on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.generateNormals);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_widgetsAreStatic(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIPanel obj = (UIPanel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name widgetsAreStatic");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index widgetsAreStatic on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.widgetsAreStatic);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_cullWhileDragging(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIPanel obj = (UIPanel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name cullWhileDragging");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index cullWhileDragging on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.cullWhileDragging);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_alwaysOnScreen(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIPanel obj = (UIPanel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name alwaysOnScreen");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index alwaysOnScreen on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.alwaysOnScreen);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_anchorOffset(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIPanel obj = (UIPanel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name anchorOffset");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index anchorOffset on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.anchorOffset);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_softBorderPadding(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIPanel obj = (UIPanel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name softBorderPadding");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index softBorderPadding on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.softBorderPadding);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_renderQueue(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIPanel obj = (UIPanel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name renderQueue");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index renderQueue on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.renderQueue);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_startingRenderQueue(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIPanel obj = (UIPanel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name startingRenderQueue");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index startingRenderQueue on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.startingRenderQueue);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_widgets(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIPanel obj = (UIPanel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name widgets");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index widgets on a nil value");
			}
		}

		LuaScriptMgr.PushObject(L, obj.widgets);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_drawCalls(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIPanel obj = (UIPanel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name drawCalls");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index drawCalls on a nil value");
			}
		}

		LuaScriptMgr.PushObject(L, obj.drawCalls);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_worldToLocal(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIPanel obj = (UIPanel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name worldToLocal");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index worldToLocal on a nil value");
			}
		}

		LuaScriptMgr.PushValue(L, obj.worldToLocal);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_drawCallClipRange(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIPanel obj = (UIPanel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name drawCallClipRange");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index drawCallClipRange on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.drawCallClipRange);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onClipMove(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIPanel obj = (UIPanel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onClipMove");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onClipMove on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.onClipMove);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_nextUnusedDepth(IntPtr L)
	{
		LuaScriptMgr.Push(L, UIPanel.nextUnusedDepth);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_canBeAnchored(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIPanel obj = (UIPanel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name canBeAnchored");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index canBeAnchored on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.canBeAnchored);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_alpha(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIPanel obj = (UIPanel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name alpha");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index alpha on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.alpha);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_depth(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIPanel obj = (UIPanel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name depth");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index depth on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.depth);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_sortingOrder(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIPanel obj = (UIPanel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name sortingOrder");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index sortingOrder on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.sortingOrder);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_width(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIPanel obj = (UIPanel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name width");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index width on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.width);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_height(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIPanel obj = (UIPanel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name height");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index height on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.height);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_halfPixelOffset(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIPanel obj = (UIPanel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name halfPixelOffset");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index halfPixelOffset on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.halfPixelOffset);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_usedForUI(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIPanel obj = (UIPanel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name usedForUI");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index usedForUI on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.usedForUI);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_drawCallOffset(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIPanel obj = (UIPanel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name drawCallOffset");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index drawCallOffset on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.drawCallOffset);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_clipping(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIPanel obj = (UIPanel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name clipping");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index clipping on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.clipping);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_parentPanel(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIPanel obj = (UIPanel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name parentPanel");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index parentPanel on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.parentPanel);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_clipCount(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIPanel obj = (UIPanel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name clipCount");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index clipCount on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.clipCount);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_hasClipping(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIPanel obj = (UIPanel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name hasClipping");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index hasClipping on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.hasClipping);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_hasCumulativeClipping(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIPanel obj = (UIPanel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name hasCumulativeClipping");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index hasCumulativeClipping on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.hasCumulativeClipping);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_clipOffset(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIPanel obj = (UIPanel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name clipOffset");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index clipOffset on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.clipOffset);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_clipTexture(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIPanel obj = (UIPanel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name clipTexture");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index clipTexture on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.clipTexture);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_baseClipRegion(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIPanel obj = (UIPanel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name baseClipRegion");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index baseClipRegion on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.baseClipRegion);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_finalClipRegion(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIPanel obj = (UIPanel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name finalClipRegion");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index finalClipRegion on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.finalClipRegion);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_clipSoftness(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIPanel obj = (UIPanel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name clipSoftness");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index clipSoftness on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.clipSoftness);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_localCorners(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIPanel obj = (UIPanel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name localCorners");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index localCorners on a nil value");
			}
		}

		LuaScriptMgr.PushArray(L, obj.localCorners);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_worldCorners(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIPanel obj = (UIPanel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name worldCorners");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index worldCorners on a nil value");
			}
		}

		LuaScriptMgr.PushArray(L, obj.worldCorners);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_list(IntPtr L)
	{
		UIPanel.list = (List<UIPanel>)LuaScriptMgr.GetNetObject(L, 3, typeof(List<UIPanel>));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onGeometryUpdated(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIPanel obj = (UIPanel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onGeometryUpdated");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onGeometryUpdated on a nil value");
			}
		}

		LuaTypes type = LuaDLL.lua_type(L, 3);

		if (type != LuaTypes.LUA_TFUNCTION)
		{
			obj.onGeometryUpdated = (UIPanel.OnGeometryUpdated)LuaScriptMgr.GetNetObject(L, 3, typeof(UIPanel.OnGeometryUpdated));
		}
		else
		{
			LuaFunction func = LuaScriptMgr.GetLuaFunction(L, 3);
			obj.onGeometryUpdated = () =>
			{
				func.Call();
			};
		}
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_showInPanelTool(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIPanel obj = (UIPanel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name showInPanelTool");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index showInPanelTool on a nil value");
			}
		}

		obj.showInPanelTool = LuaScriptMgr.GetBoolean(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_generateNormals(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIPanel obj = (UIPanel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name generateNormals");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index generateNormals on a nil value");
			}
		}

		obj.generateNormals = LuaScriptMgr.GetBoolean(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_widgetsAreStatic(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIPanel obj = (UIPanel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name widgetsAreStatic");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index widgetsAreStatic on a nil value");
			}
		}

		obj.widgetsAreStatic = LuaScriptMgr.GetBoolean(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_cullWhileDragging(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIPanel obj = (UIPanel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name cullWhileDragging");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index cullWhileDragging on a nil value");
			}
		}

		obj.cullWhileDragging = LuaScriptMgr.GetBoolean(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_alwaysOnScreen(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIPanel obj = (UIPanel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name alwaysOnScreen");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index alwaysOnScreen on a nil value");
			}
		}

		obj.alwaysOnScreen = LuaScriptMgr.GetBoolean(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_anchorOffset(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIPanel obj = (UIPanel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name anchorOffset");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index anchorOffset on a nil value");
			}
		}

		obj.anchorOffset = LuaScriptMgr.GetBoolean(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_softBorderPadding(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIPanel obj = (UIPanel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name softBorderPadding");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index softBorderPadding on a nil value");
			}
		}

		obj.softBorderPadding = LuaScriptMgr.GetBoolean(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_renderQueue(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIPanel obj = (UIPanel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name renderQueue");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index renderQueue on a nil value");
			}
		}

		obj.renderQueue = (UIPanel.RenderQueue)LuaScriptMgr.GetNetObject(L, 3, typeof(UIPanel.RenderQueue));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_startingRenderQueue(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIPanel obj = (UIPanel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name startingRenderQueue");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index startingRenderQueue on a nil value");
			}
		}

		obj.startingRenderQueue = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_widgets(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIPanel obj = (UIPanel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name widgets");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index widgets on a nil value");
			}
		}

		obj.widgets = (List<UIWidget>)LuaScriptMgr.GetNetObject(L, 3, typeof(List<UIWidget>));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_drawCalls(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIPanel obj = (UIPanel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name drawCalls");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index drawCalls on a nil value");
			}
		}

		obj.drawCalls = (List<UIDrawCall>)LuaScriptMgr.GetNetObject(L, 3, typeof(List<UIDrawCall>));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_worldToLocal(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIPanel obj = (UIPanel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name worldToLocal");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index worldToLocal on a nil value");
			}
		}

		obj.worldToLocal = (Matrix4x4)LuaScriptMgr.GetNetObject(L, 3, typeof(Matrix4x4));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_drawCallClipRange(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIPanel obj = (UIPanel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name drawCallClipRange");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index drawCallClipRange on a nil value");
			}
		}

		obj.drawCallClipRange = LuaScriptMgr.GetVector4(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onClipMove(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIPanel obj = (UIPanel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name onClipMove");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index onClipMove on a nil value");
			}
		}

		LuaTypes type = LuaDLL.lua_type(L, 3);

		if (type != LuaTypes.LUA_TFUNCTION)
		{
			obj.onClipMove = (UIPanel.OnClippingMoved)LuaScriptMgr.GetNetObject(L, 3, typeof(UIPanel.OnClippingMoved));
		}
		else
		{
			LuaFunction func = LuaScriptMgr.GetLuaFunction(L, 3);
			obj.onClipMove = (arg0) =>
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
	static int set_alpha(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIPanel obj = (UIPanel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name alpha");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index alpha on a nil value");
			}
		}

		obj.alpha = (float)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_depth(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIPanel obj = (UIPanel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name depth");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index depth on a nil value");
			}
		}

		obj.depth = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_sortingOrder(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIPanel obj = (UIPanel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name sortingOrder");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index sortingOrder on a nil value");
			}
		}

		obj.sortingOrder = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_clipping(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIPanel obj = (UIPanel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name clipping");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index clipping on a nil value");
			}
		}

		obj.clipping = (UIDrawCall.Clipping)LuaScriptMgr.GetNetObject(L, 3, typeof(UIDrawCall.Clipping));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_clipOffset(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIPanel obj = (UIPanel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name clipOffset");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index clipOffset on a nil value");
			}
		}

		obj.clipOffset = LuaScriptMgr.GetVector2(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_clipTexture(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIPanel obj = (UIPanel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name clipTexture");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index clipTexture on a nil value");
			}
		}

		obj.clipTexture = (Texture2D)LuaScriptMgr.GetUnityObject(L, 3, typeof(Texture2D));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_baseClipRegion(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIPanel obj = (UIPanel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name baseClipRegion");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index baseClipRegion on a nil value");
			}
		}

		obj.baseClipRegion = LuaScriptMgr.GetVector4(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_clipSoftness(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIPanel obj = (UIPanel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name clipSoftness");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index clipSoftness on a nil value");
			}
		}

		obj.clipSoftness = LuaScriptMgr.GetVector2(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CompareFunc(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		UIPanel arg0 = (UIPanel)LuaScriptMgr.GetUnityObject(L, 1, typeof(UIPanel));
		UIPanel arg1 = (UIPanel)LuaScriptMgr.GetUnityObject(L, 2, typeof(UIPanel));
		int o = UIPanel.CompareFunc(arg0,arg1);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetSides(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		UIPanel obj = (UIPanel)LuaScriptMgr.GetUnityObject(L, 1, typeof(UIPanel));
		Transform arg0 = (Transform)LuaScriptMgr.GetUnityObject(L, 2, typeof(Transform));
		Vector3[] o = obj.GetSides(arg0);
		LuaScriptMgr.PushArray(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Invalidate(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		UIPanel obj = (UIPanel)LuaScriptMgr.GetUnityObject(L, 1, typeof(UIPanel));
		bool arg0 = LuaScriptMgr.GetBoolean(L, 2);
		obj.Invalidate(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CalculateFinalAlpha(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		UIPanel obj = (UIPanel)LuaScriptMgr.GetUnityObject(L, 1, typeof(UIPanel));
		int arg0 = (int)LuaScriptMgr.GetNumber(L, 2);
		float o = obj.CalculateFinalAlpha(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetRect(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 5);
		UIPanel obj = (UIPanel)LuaScriptMgr.GetUnityObject(L, 1, typeof(UIPanel));
		float arg0 = (float)LuaScriptMgr.GetNumber(L, 2);
		float arg1 = (float)LuaScriptMgr.GetNumber(L, 3);
		float arg2 = (float)LuaScriptMgr.GetNumber(L, 4);
		float arg3 = (float)LuaScriptMgr.GetNumber(L, 5);
		obj.SetRect(arg0,arg1,arg2,arg3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IsVisible(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 2 && LuaScriptMgr.CheckTypes(L, 1, typeof(UIPanel), typeof(UIWidget)))
		{
			UIPanel obj = (UIPanel)LuaScriptMgr.GetUnityObject(L, 1, typeof(UIPanel));
			UIWidget arg0 = (UIWidget)LuaScriptMgr.GetUnityObject(L, 2, typeof(UIWidget));
			bool o = obj.IsVisible(arg0);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 2 && LuaScriptMgr.CheckTypes(L, 1, typeof(UIPanel), typeof(LuaTable)))
		{
			UIPanel obj = (UIPanel)LuaScriptMgr.GetUnityObject(L, 1, typeof(UIPanel));
			Vector3 arg0 = LuaScriptMgr.GetVector3(L, 2);
			bool o = obj.IsVisible(arg0);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 5)
		{
			UIPanel obj = (UIPanel)LuaScriptMgr.GetUnityObject(L, 1, typeof(UIPanel));
			Vector3 arg0 = LuaScriptMgr.GetVector3(L, 2);
			Vector3 arg1 = LuaScriptMgr.GetVector3(L, 3);
			Vector3 arg2 = LuaScriptMgr.GetVector3(L, 4);
			Vector3 arg3 = LuaScriptMgr.GetVector3(L, 5);
			bool o = obj.IsVisible(arg0,arg1,arg2,arg3);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: UIPanel.IsVisible");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Affects(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		UIPanel obj = (UIPanel)LuaScriptMgr.GetUnityObject(L, 1, typeof(UIPanel));
		UIWidget arg0 = (UIWidget)LuaScriptMgr.GetUnityObject(L, 2, typeof(UIWidget));
		bool o = obj.Affects(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RebuildAllDrawCalls(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		UIPanel obj = (UIPanel)LuaScriptMgr.GetUnityObject(L, 1, typeof(UIPanel));
		obj.RebuildAllDrawCalls();
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetDirty(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		UIPanel obj = (UIPanel)LuaScriptMgr.GetUnityObject(L, 1, typeof(UIPanel));
		obj.SetDirty();
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ParentHasChanged(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		UIPanel obj = (UIPanel)LuaScriptMgr.GetUnityObject(L, 1, typeof(UIPanel));
		obj.ParentHasChanged();
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SortWidgets(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		UIPanel obj = (UIPanel)LuaScriptMgr.GetUnityObject(L, 1, typeof(UIPanel));
		obj.SortWidgets();
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int FindDrawCall(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		UIPanel obj = (UIPanel)LuaScriptMgr.GetUnityObject(L, 1, typeof(UIPanel));
		UIWidget arg0 = (UIWidget)LuaScriptMgr.GetUnityObject(L, 2, typeof(UIWidget));
		UIDrawCall o = obj.FindDrawCall(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddWidget(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		UIPanel obj = (UIPanel)LuaScriptMgr.GetUnityObject(L, 1, typeof(UIPanel));
		UIWidget arg0 = (UIWidget)LuaScriptMgr.GetUnityObject(L, 2, typeof(UIWidget));
		obj.AddWidget(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RemoveWidget(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		UIPanel obj = (UIPanel)LuaScriptMgr.GetUnityObject(L, 1, typeof(UIPanel));
		UIWidget arg0 = (UIWidget)LuaScriptMgr.GetUnityObject(L, 2, typeof(UIWidget));
		obj.RemoveWidget(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Refresh(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		UIPanel obj = (UIPanel)LuaScriptMgr.GetUnityObject(L, 1, typeof(UIPanel));
		obj.Refresh();
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CalculateConstrainOffset(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 3);
		UIPanel obj = (UIPanel)LuaScriptMgr.GetUnityObject(L, 1, typeof(UIPanel));
		Vector2 arg0 = LuaScriptMgr.GetVector2(L, 2);
		Vector2 arg1 = LuaScriptMgr.GetVector2(L, 3);
		Vector3 o = obj.CalculateConstrainOffset(arg0,arg1);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ConstrainTargetToBounds(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);
		if (count == 3)
		{
			UIPanel obj = (UIPanel)LuaScriptMgr.GetUnityObject(L, 1, typeof(UIPanel));
			Transform arg0 = (Transform)LuaScriptMgr.GetUnityObject(L, 2, typeof(Transform));
			bool arg1 = LuaScriptMgr.GetBoolean(L, 3);
			bool o = obj.ConstrainTargetToBounds(arg0,arg1);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 4)
		{
			UIPanel obj = (UIPanel)LuaScriptMgr.GetUnityObject(L, 1, typeof(UIPanel));
			Transform arg0 = (Transform)LuaScriptMgr.GetUnityObject(L, 2, typeof(Transform));
			Bounds arg1 = LuaScriptMgr.GetBounds(L, 3);
			bool arg2 = LuaScriptMgr.GetBoolean(L, 4);
			bool o = obj.ConstrainTargetToBounds(arg0,ref arg1,arg2);
			LuaScriptMgr.Push(L, o);
			LuaScriptMgr.Push(L, arg1);
			return 2;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: UIPanel.ConstrainTargetToBounds");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Find(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);
		if (count == 1)
		{
			Transform arg0 = (Transform)LuaScriptMgr.GetUnityObject(L, 1, typeof(Transform));
			UIPanel o = UIPanel.Find(arg0);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 2)
		{
			Transform arg0 = (Transform)LuaScriptMgr.GetUnityObject(L, 1, typeof(Transform));
			bool arg1 = LuaScriptMgr.GetBoolean(L, 2);
			UIPanel o = UIPanel.Find(arg0,arg1);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 3)
		{
			Transform arg0 = (Transform)LuaScriptMgr.GetUnityObject(L, 1, typeof(Transform));
			bool arg1 = LuaScriptMgr.GetBoolean(L, 2);
			int arg2 = (int)LuaScriptMgr.GetNumber(L, 3);
			UIPanel o = UIPanel.Find(arg0,arg1,arg2);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: UIPanel.Find");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetWindowSize(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		UIPanel obj = (UIPanel)LuaScriptMgr.GetUnityObject(L, 1, typeof(UIPanel));
		Vector2 o = obj.GetWindowSize();
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetViewSize(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		UIPanel obj = (UIPanel)LuaScriptMgr.GetUnityObject(L, 1, typeof(UIPanel));
		Vector2 o = obj.GetViewSize();
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

