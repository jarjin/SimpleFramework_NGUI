using System;
using UnityEngine;
using LuaInterface;
using Object = UnityEngine.Object;

public class UIRectWrap
{
	public static LuaMethod[] regs = new LuaMethod[]
	{
		new LuaMethod("CalculateFinalAlpha", CalculateFinalAlpha),
		new LuaMethod("Invalidate", Invalidate),
		new LuaMethod("GetSides", GetSides),
		new LuaMethod("Update", Update),
		new LuaMethod("UpdateAnchors", UpdateAnchors),
		new LuaMethod("SetAnchor", SetAnchor),
		new LuaMethod("ResetAnchors", ResetAnchors),
		new LuaMethod("ResetAndUpdateAnchors", ResetAndUpdateAnchors),
		new LuaMethod("SetRect", SetRect),
		new LuaMethod("ParentHasChanged", ParentHasChanged),
		new LuaMethod("New", _CreateUIRect),
		new LuaMethod("GetClassType", GetClassType),
		new LuaMethod("__eq", Lua_Eq),
	};

	static LuaField[] fields = new LuaField[]
	{
		new LuaField("leftAnchor", get_leftAnchor, set_leftAnchor),
		new LuaField("rightAnchor", get_rightAnchor, set_rightAnchor),
		new LuaField("bottomAnchor", get_bottomAnchor, set_bottomAnchor),
		new LuaField("topAnchor", get_topAnchor, set_topAnchor),
		new LuaField("updateAnchors", get_updateAnchors, set_updateAnchors),
		new LuaField("finalAlpha", get_finalAlpha, set_finalAlpha),
		new LuaField("cachedGameObject", get_cachedGameObject, null),
		new LuaField("cachedTransform", get_cachedTransform, null),
		new LuaField("anchorCamera", get_anchorCamera, null),
		new LuaField("isFullyAnchored", get_isFullyAnchored, null),
		new LuaField("isAnchoredHorizontally", get_isAnchoredHorizontally, null),
		new LuaField("isAnchoredVertically", get_isAnchoredVertically, null),
		new LuaField("canBeAnchored", get_canBeAnchored, null),
		new LuaField("parent", get_parent, null),
		new LuaField("root", get_root, null),
		new LuaField("isAnchored", get_isAnchored, null),
		new LuaField("alpha", get_alpha, set_alpha),
		new LuaField("localCorners", get_localCorners, null),
		new LuaField("worldCorners", get_worldCorners, null),
	};

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateUIRect(IntPtr L)
	{
		LuaDLL.luaL_error(L, "UIRect class does not have a constructor function");
		return 0;
	}

	static Type classType = typeof(UIRect);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);

		return 1;
	}

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "UIRect", typeof(UIRect), regs, fields, typeof(MonoBehaviour));
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_leftAnchor(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIRect obj = (UIRect)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name leftAnchor");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index leftAnchor on a nil value");
			}
		}

		LuaScriptMgr.PushObject(L, obj.leftAnchor);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_rightAnchor(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIRect obj = (UIRect)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name rightAnchor");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index rightAnchor on a nil value");
			}
		}

		LuaScriptMgr.PushObject(L, obj.rightAnchor);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_bottomAnchor(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIRect obj = (UIRect)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name bottomAnchor");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index bottomAnchor on a nil value");
			}
		}

		LuaScriptMgr.PushObject(L, obj.bottomAnchor);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_topAnchor(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIRect obj = (UIRect)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name topAnchor");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index topAnchor on a nil value");
			}
		}

		LuaScriptMgr.PushObject(L, obj.topAnchor);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_updateAnchors(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIRect obj = (UIRect)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name updateAnchors");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index updateAnchors on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.updateAnchors);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_finalAlpha(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIRect obj = (UIRect)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name finalAlpha");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index finalAlpha on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.finalAlpha);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_cachedGameObject(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIRect obj = (UIRect)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name cachedGameObject");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index cachedGameObject on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.cachedGameObject);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_cachedTransform(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIRect obj = (UIRect)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name cachedTransform");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index cachedTransform on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.cachedTransform);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_anchorCamera(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIRect obj = (UIRect)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name anchorCamera");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index anchorCamera on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.anchorCamera);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_isFullyAnchored(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIRect obj = (UIRect)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name isFullyAnchored");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index isFullyAnchored on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.isFullyAnchored);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_isAnchoredHorizontally(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIRect obj = (UIRect)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name isAnchoredHorizontally");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index isAnchoredHorizontally on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.isAnchoredHorizontally);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_isAnchoredVertically(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIRect obj = (UIRect)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name isAnchoredVertically");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index isAnchoredVertically on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.isAnchoredVertically);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_canBeAnchored(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIRect obj = (UIRect)o;

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
	static int get_parent(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIRect obj = (UIRect)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name parent");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index parent on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.parent);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_root(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIRect obj = (UIRect)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name root");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index root on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.root);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_isAnchored(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIRect obj = (UIRect)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name isAnchored");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index isAnchored on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.isAnchored);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_alpha(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIRect obj = (UIRect)o;

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
	static int get_localCorners(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIRect obj = (UIRect)o;

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
		UIRect obj = (UIRect)o;

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
	static int set_leftAnchor(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIRect obj = (UIRect)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name leftAnchor");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index leftAnchor on a nil value");
			}
		}

		obj.leftAnchor = (UIRect.AnchorPoint)LuaScriptMgr.GetNetObject(L, 3, typeof(UIRect.AnchorPoint));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_rightAnchor(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIRect obj = (UIRect)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name rightAnchor");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index rightAnchor on a nil value");
			}
		}

		obj.rightAnchor = (UIRect.AnchorPoint)LuaScriptMgr.GetNetObject(L, 3, typeof(UIRect.AnchorPoint));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_bottomAnchor(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIRect obj = (UIRect)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name bottomAnchor");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index bottomAnchor on a nil value");
			}
		}

		obj.bottomAnchor = (UIRect.AnchorPoint)LuaScriptMgr.GetNetObject(L, 3, typeof(UIRect.AnchorPoint));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_topAnchor(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIRect obj = (UIRect)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name topAnchor");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index topAnchor on a nil value");
			}
		}

		obj.topAnchor = (UIRect.AnchorPoint)LuaScriptMgr.GetNetObject(L, 3, typeof(UIRect.AnchorPoint));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_updateAnchors(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIRect obj = (UIRect)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name updateAnchors");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index updateAnchors on a nil value");
			}
		}

		obj.updateAnchors = (UIRect.AnchorUpdate)LuaScriptMgr.GetNetObject(L, 3, typeof(UIRect.AnchorUpdate));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_finalAlpha(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIRect obj = (UIRect)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name finalAlpha");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index finalAlpha on a nil value");
			}
		}

		obj.finalAlpha = (float)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_alpha(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UIRect obj = (UIRect)o;

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
	static int CalculateFinalAlpha(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		UIRect obj = (UIRect)LuaScriptMgr.GetUnityObject(L, 1, typeof(UIRect));
		int arg0 = (int)LuaScriptMgr.GetNumber(L, 2);
		float o = obj.CalculateFinalAlpha(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Invalidate(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		UIRect obj = (UIRect)LuaScriptMgr.GetUnityObject(L, 1, typeof(UIRect));
		bool arg0 = LuaScriptMgr.GetBoolean(L, 2);
		obj.Invalidate(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetSides(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		UIRect obj = (UIRect)LuaScriptMgr.GetUnityObject(L, 1, typeof(UIRect));
		Transform arg0 = (Transform)LuaScriptMgr.GetUnityObject(L, 2, typeof(Transform));
		Vector3[] o = obj.GetSides(arg0);
		LuaScriptMgr.PushArray(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Update(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		UIRect obj = (UIRect)LuaScriptMgr.GetUnityObject(L, 1, typeof(UIRect));
		obj.Update();
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UpdateAnchors(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		UIRect obj = (UIRect)LuaScriptMgr.GetUnityObject(L, 1, typeof(UIRect));
		obj.UpdateAnchors();
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetAnchor(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 2 && LuaScriptMgr.CheckTypes(L, 1, typeof(UIRect), typeof(GameObject)))
		{
			UIRect obj = (UIRect)LuaScriptMgr.GetUnityObject(L, 1, typeof(UIRect));
			GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 2, typeof(GameObject));
			obj.SetAnchor(arg0);
			return 0;
		}
		else if (count == 2 && LuaScriptMgr.CheckTypes(L, 1, typeof(UIRect), typeof(Transform)))
		{
			UIRect obj = (UIRect)LuaScriptMgr.GetUnityObject(L, 1, typeof(UIRect));
			Transform arg0 = (Transform)LuaScriptMgr.GetUnityObject(L, 2, typeof(Transform));
			obj.SetAnchor(arg0);
			return 0;
		}
		else if (count == 6)
		{
			UIRect obj = (UIRect)LuaScriptMgr.GetUnityObject(L, 1, typeof(UIRect));
			GameObject arg0 = (GameObject)LuaScriptMgr.GetUnityObject(L, 2, typeof(GameObject));
			int arg1 = (int)LuaScriptMgr.GetNumber(L, 3);
			int arg2 = (int)LuaScriptMgr.GetNumber(L, 4);
			int arg3 = (int)LuaScriptMgr.GetNumber(L, 5);
			int arg4 = (int)LuaScriptMgr.GetNumber(L, 6);
			obj.SetAnchor(arg0,arg1,arg2,arg3,arg4);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: UIRect.SetAnchor");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ResetAnchors(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		UIRect obj = (UIRect)LuaScriptMgr.GetUnityObject(L, 1, typeof(UIRect));
		obj.ResetAnchors();
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ResetAndUpdateAnchors(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		UIRect obj = (UIRect)LuaScriptMgr.GetUnityObject(L, 1, typeof(UIRect));
		obj.ResetAndUpdateAnchors();
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetRect(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 5);
		UIRect obj = (UIRect)LuaScriptMgr.GetUnityObject(L, 1, typeof(UIRect));
		float arg0 = (float)LuaScriptMgr.GetNumber(L, 2);
		float arg1 = (float)LuaScriptMgr.GetNumber(L, 3);
		float arg2 = (float)LuaScriptMgr.GetNumber(L, 4);
		float arg3 = (float)LuaScriptMgr.GetNumber(L, 5);
		obj.SetRect(arg0,arg1,arg2,arg3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ParentHasChanged(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		UIRect obj = (UIRect)LuaScriptMgr.GetUnityObject(L, 1, typeof(UIRect));
		obj.ParentHasChanged();
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

