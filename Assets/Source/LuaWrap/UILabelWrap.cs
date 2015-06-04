using System;
using UnityEngine;
using LuaInterface;
using Object = UnityEngine.Object;

public class UILabelWrap
{
	public static LuaMethod[] regs = new LuaMethod[]
	{
		new LuaMethod("GetSides", GetSides),
		new LuaMethod("MarkAsChanged", MarkAsChanged),
		new LuaMethod("ProcessText", ProcessText),
		new LuaMethod("MakePixelPerfect", MakePixelPerfect),
		new LuaMethod("AssumeNaturalSize", AssumeNaturalSize),
		new LuaMethod("GetCharacterIndexAtPosition", GetCharacterIndexAtPosition),
		new LuaMethod("GetWordAtPosition", GetWordAtPosition),
		new LuaMethod("GetWordAtCharacterIndex", GetWordAtCharacterIndex),
		new LuaMethod("GetUrlAtPosition", GetUrlAtPosition),
		new LuaMethod("GetUrlAtCharacterIndex", GetUrlAtCharacterIndex),
		new LuaMethod("GetCharacterIndex", GetCharacterIndex),
		new LuaMethod("PrintOverlay", PrintOverlay),
		new LuaMethod("OnFill", OnFill),
		new LuaMethod("ApplyOffset", ApplyOffset),
		new LuaMethod("ApplyShadow", ApplyShadow),
		new LuaMethod("CalculateOffsetToFit", CalculateOffsetToFit),
		new LuaMethod("SetCurrentProgress", SetCurrentProgress),
		new LuaMethod("SetCurrentPercent", SetCurrentPercent),
		new LuaMethod("SetCurrentSelection", SetCurrentSelection),
		new LuaMethod("Wrap", Wrap),
		new LuaMethod("UpdateNGUIText", UpdateNGUIText),
		new LuaMethod("New", _CreateUILabel),
		new LuaMethod("GetClassType", GetClassType),
		new LuaMethod("__eq", Lua_Eq),
	};

	static LuaField[] fields = new LuaField[]
	{
		new LuaField("keepCrispWhenShrunk", get_keepCrispWhenShrunk, set_keepCrispWhenShrunk),
		new LuaField("isAnchoredHorizontally", get_isAnchoredHorizontally, null),
		new LuaField("isAnchoredVertically", get_isAnchoredVertically, null),
		new LuaField("material", get_material, set_material),
		new LuaField("bitmapFont", get_bitmapFont, set_bitmapFont),
		new LuaField("trueTypeFont", get_trueTypeFont, set_trueTypeFont),
		new LuaField("ambigiousFont", get_ambigiousFont, set_ambigiousFont),
		new LuaField("text", get_text, set_text),
		new LuaField("defaultFontSize", get_defaultFontSize, null),
		new LuaField("fontSize", get_fontSize, set_fontSize),
		new LuaField("fontStyle", get_fontStyle, set_fontStyle),
		new LuaField("alignment", get_alignment, set_alignment),
		new LuaField("applyGradient", get_applyGradient, set_applyGradient),
		new LuaField("gradientTop", get_gradientTop, set_gradientTop),
		new LuaField("gradientBottom", get_gradientBottom, set_gradientBottom),
		new LuaField("spacingX", get_spacingX, set_spacingX),
		new LuaField("spacingY", get_spacingY, set_spacingY),
		new LuaField("useFloatSpacing", get_useFloatSpacing, set_useFloatSpacing),
		new LuaField("floatSpacingX", get_floatSpacingX, set_floatSpacingX),
		new LuaField("floatSpacingY", get_floatSpacingY, set_floatSpacingY),
		new LuaField("effectiveSpacingY", get_effectiveSpacingY, null),
		new LuaField("effectiveSpacingX", get_effectiveSpacingX, null),
		new LuaField("supportEncoding", get_supportEncoding, set_supportEncoding),
		new LuaField("symbolStyle", get_symbolStyle, set_symbolStyle),
		new LuaField("overflowMethod", get_overflowMethod, set_overflowMethod),
		new LuaField("multiLine", get_multiLine, set_multiLine),
		new LuaField("localCorners", get_localCorners, null),
		new LuaField("worldCorners", get_worldCorners, null),
		new LuaField("drawingDimensions", get_drawingDimensions, null),
		new LuaField("maxLineCount", get_maxLineCount, set_maxLineCount),
		new LuaField("effectStyle", get_effectStyle, set_effectStyle),
		new LuaField("effectColor", get_effectColor, set_effectColor),
		new LuaField("effectDistance", get_effectDistance, set_effectDistance),
		new LuaField("processedText", get_processedText, null),
		new LuaField("printedSize", get_printedSize, null),
		new LuaField("localSize", get_localSize, null),
	};

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateUILabel(IntPtr L)
	{
		LuaDLL.luaL_error(L, "UILabel class does not have a constructor function");
		return 0;
	}

	static Type classType = typeof(UILabel);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);

		return 1;
	}

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, "UILabel", typeof(UILabel), regs, fields, typeof(UIWidget));
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_keepCrispWhenShrunk(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UILabel obj = (UILabel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name keepCrispWhenShrunk");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index keepCrispWhenShrunk on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.keepCrispWhenShrunk);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_isAnchoredHorizontally(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UILabel obj = (UILabel)o;

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
		UILabel obj = (UILabel)o;

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
	static int get_material(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UILabel obj = (UILabel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name material");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index material on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.material);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_bitmapFont(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UILabel obj = (UILabel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name bitmapFont");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index bitmapFont on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.bitmapFont);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_trueTypeFont(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UILabel obj = (UILabel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name trueTypeFont");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index trueTypeFont on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.trueTypeFont);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_ambigiousFont(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UILabel obj = (UILabel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name ambigiousFont");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index ambigiousFont on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.ambigiousFont);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_text(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UILabel obj = (UILabel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name text");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index text on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.text);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_defaultFontSize(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UILabel obj = (UILabel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name defaultFontSize");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index defaultFontSize on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.defaultFontSize);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_fontSize(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UILabel obj = (UILabel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name fontSize");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index fontSize on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.fontSize);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_fontStyle(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UILabel obj = (UILabel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name fontStyle");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index fontStyle on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.fontStyle);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_alignment(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UILabel obj = (UILabel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name alignment");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index alignment on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.alignment);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_applyGradient(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UILabel obj = (UILabel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name applyGradient");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index applyGradient on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.applyGradient);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_gradientTop(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UILabel obj = (UILabel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name gradientTop");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index gradientTop on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.gradientTop);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_gradientBottom(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UILabel obj = (UILabel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name gradientBottom");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index gradientBottom on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.gradientBottom);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_spacingX(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UILabel obj = (UILabel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name spacingX");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index spacingX on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.spacingX);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_spacingY(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UILabel obj = (UILabel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name spacingY");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index spacingY on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.spacingY);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_useFloatSpacing(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UILabel obj = (UILabel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name useFloatSpacing");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index useFloatSpacing on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.useFloatSpacing);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_floatSpacingX(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UILabel obj = (UILabel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name floatSpacingX");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index floatSpacingX on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.floatSpacingX);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_floatSpacingY(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UILabel obj = (UILabel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name floatSpacingY");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index floatSpacingY on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.floatSpacingY);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_effectiveSpacingY(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UILabel obj = (UILabel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name effectiveSpacingY");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index effectiveSpacingY on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.effectiveSpacingY);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_effectiveSpacingX(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UILabel obj = (UILabel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name effectiveSpacingX");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index effectiveSpacingX on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.effectiveSpacingX);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_supportEncoding(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UILabel obj = (UILabel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name supportEncoding");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index supportEncoding on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.supportEncoding);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_symbolStyle(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UILabel obj = (UILabel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name symbolStyle");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index symbolStyle on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.symbolStyle);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_overflowMethod(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UILabel obj = (UILabel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name overflowMethod");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index overflowMethod on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.overflowMethod);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_multiLine(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UILabel obj = (UILabel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name multiLine");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index multiLine on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.multiLine);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_localCorners(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UILabel obj = (UILabel)o;

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
		UILabel obj = (UILabel)o;

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
	static int get_drawingDimensions(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UILabel obj = (UILabel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name drawingDimensions");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index drawingDimensions on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.drawingDimensions);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_maxLineCount(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UILabel obj = (UILabel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name maxLineCount");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index maxLineCount on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.maxLineCount);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_effectStyle(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UILabel obj = (UILabel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name effectStyle");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index effectStyle on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.effectStyle);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_effectColor(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UILabel obj = (UILabel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name effectColor");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index effectColor on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.effectColor);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_effectDistance(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UILabel obj = (UILabel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name effectDistance");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index effectDistance on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.effectDistance);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_processedText(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UILabel obj = (UILabel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name processedText");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index processedText on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.processedText);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_printedSize(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UILabel obj = (UILabel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name printedSize");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index printedSize on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.printedSize);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_localSize(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UILabel obj = (UILabel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name localSize");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index localSize on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.localSize);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_keepCrispWhenShrunk(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UILabel obj = (UILabel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name keepCrispWhenShrunk");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index keepCrispWhenShrunk on a nil value");
			}
		}

		obj.keepCrispWhenShrunk = (UILabel.Crispness)LuaScriptMgr.GetNetObject(L, 3, typeof(UILabel.Crispness));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_material(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UILabel obj = (UILabel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name material");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index material on a nil value");
			}
		}

		obj.material = (Material)LuaScriptMgr.GetUnityObject(L, 3, typeof(Material));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_bitmapFont(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UILabel obj = (UILabel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name bitmapFont");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index bitmapFont on a nil value");
			}
		}

		obj.bitmapFont = (UIFont)LuaScriptMgr.GetUnityObject(L, 3, typeof(UIFont));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_trueTypeFont(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UILabel obj = (UILabel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name trueTypeFont");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index trueTypeFont on a nil value");
			}
		}

		obj.trueTypeFont = (Font)LuaScriptMgr.GetUnityObject(L, 3, typeof(Font));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_ambigiousFont(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UILabel obj = (UILabel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name ambigiousFont");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index ambigiousFont on a nil value");
			}
		}

		obj.ambigiousFont = (Object)LuaScriptMgr.GetUnityObject(L, 3, typeof(Object));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_text(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UILabel obj = (UILabel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name text");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index text on a nil value");
			}
		}

		obj.text = LuaScriptMgr.GetString(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_fontSize(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UILabel obj = (UILabel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name fontSize");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index fontSize on a nil value");
			}
		}

		obj.fontSize = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_fontStyle(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UILabel obj = (UILabel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name fontStyle");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index fontStyle on a nil value");
			}
		}

		obj.fontStyle = (FontStyle)LuaScriptMgr.GetNetObject(L, 3, typeof(FontStyle));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_alignment(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UILabel obj = (UILabel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name alignment");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index alignment on a nil value");
			}
		}

		obj.alignment = (NGUIText.Alignment)LuaScriptMgr.GetNetObject(L, 3, typeof(NGUIText.Alignment));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_applyGradient(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UILabel obj = (UILabel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name applyGradient");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index applyGradient on a nil value");
			}
		}

		obj.applyGradient = LuaScriptMgr.GetBoolean(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_gradientTop(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UILabel obj = (UILabel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name gradientTop");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index gradientTop on a nil value");
			}
		}

		obj.gradientTop = LuaScriptMgr.GetColor(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_gradientBottom(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UILabel obj = (UILabel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name gradientBottom");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index gradientBottom on a nil value");
			}
		}

		obj.gradientBottom = LuaScriptMgr.GetColor(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_spacingX(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UILabel obj = (UILabel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name spacingX");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index spacingX on a nil value");
			}
		}

		obj.spacingX = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_spacingY(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UILabel obj = (UILabel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name spacingY");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index spacingY on a nil value");
			}
		}

		obj.spacingY = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_useFloatSpacing(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UILabel obj = (UILabel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name useFloatSpacing");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index useFloatSpacing on a nil value");
			}
		}

		obj.useFloatSpacing = LuaScriptMgr.GetBoolean(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_floatSpacingX(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UILabel obj = (UILabel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name floatSpacingX");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index floatSpacingX on a nil value");
			}
		}

		obj.floatSpacingX = (float)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_floatSpacingY(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UILabel obj = (UILabel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name floatSpacingY");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index floatSpacingY on a nil value");
			}
		}

		obj.floatSpacingY = (float)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_supportEncoding(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UILabel obj = (UILabel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name supportEncoding");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index supportEncoding on a nil value");
			}
		}

		obj.supportEncoding = LuaScriptMgr.GetBoolean(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_symbolStyle(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UILabel obj = (UILabel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name symbolStyle");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index symbolStyle on a nil value");
			}
		}

		obj.symbolStyle = (NGUIText.SymbolStyle)LuaScriptMgr.GetNetObject(L, 3, typeof(NGUIText.SymbolStyle));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_overflowMethod(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UILabel obj = (UILabel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name overflowMethod");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index overflowMethod on a nil value");
			}
		}

		obj.overflowMethod = (UILabel.Overflow)LuaScriptMgr.GetNetObject(L, 3, typeof(UILabel.Overflow));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_multiLine(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UILabel obj = (UILabel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name multiLine");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index multiLine on a nil value");
			}
		}

		obj.multiLine = LuaScriptMgr.GetBoolean(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_maxLineCount(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UILabel obj = (UILabel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name maxLineCount");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index maxLineCount on a nil value");
			}
		}

		obj.maxLineCount = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_effectStyle(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UILabel obj = (UILabel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name effectStyle");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index effectStyle on a nil value");
			}
		}

		obj.effectStyle = (UILabel.Effect)LuaScriptMgr.GetNetObject(L, 3, typeof(UILabel.Effect));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_effectColor(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UILabel obj = (UILabel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name effectColor");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index effectColor on a nil value");
			}
		}

		obj.effectColor = LuaScriptMgr.GetColor(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_effectDistance(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		UILabel obj = (UILabel)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name effectDistance");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index effectDistance on a nil value");
			}
		}

		obj.effectDistance = LuaScriptMgr.GetVector2(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetSides(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		UILabel obj = (UILabel)LuaScriptMgr.GetUnityObject(L, 1, typeof(UILabel));
		Transform arg0 = (Transform)LuaScriptMgr.GetUnityObject(L, 2, typeof(Transform));
		Vector3[] o = obj.GetSides(arg0);
		LuaScriptMgr.PushArray(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int MarkAsChanged(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		UILabel obj = (UILabel)LuaScriptMgr.GetUnityObject(L, 1, typeof(UILabel));
		obj.MarkAsChanged();
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ProcessText(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		UILabel obj = (UILabel)LuaScriptMgr.GetUnityObject(L, 1, typeof(UILabel));
		obj.ProcessText();
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int MakePixelPerfect(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		UILabel obj = (UILabel)LuaScriptMgr.GetUnityObject(L, 1, typeof(UILabel));
		obj.MakePixelPerfect();
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AssumeNaturalSize(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		UILabel obj = (UILabel)LuaScriptMgr.GetUnityObject(L, 1, typeof(UILabel));
		obj.AssumeNaturalSize();
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetCharacterIndexAtPosition(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 3 && LuaScriptMgr.CheckTypes(L, 1, typeof(UILabel), typeof(LuaTable), typeof(bool)))
		{
			UILabel obj = (UILabel)LuaScriptMgr.GetUnityObject(L, 1, typeof(UILabel));
			Vector2 arg0 = LuaScriptMgr.GetVector2(L, 2);
			bool arg1 = LuaScriptMgr.GetBoolean(L, 3);
			int o = obj.GetCharacterIndexAtPosition(arg0,arg1);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 3 && LuaScriptMgr.CheckTypes(L, 1, typeof(UILabel), typeof(LuaTable), typeof(bool)))
		{
			UILabel obj = (UILabel)LuaScriptMgr.GetUnityObject(L, 1, typeof(UILabel));
			Vector3 arg0 = LuaScriptMgr.GetVector3(L, 2);
			bool arg1 = LuaScriptMgr.GetBoolean(L, 3);
			int o = obj.GetCharacterIndexAtPosition(arg0,arg1);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: UILabel.GetCharacterIndexAtPosition");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetWordAtPosition(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 2 && LuaScriptMgr.CheckTypes(L, 1, typeof(UILabel), typeof(LuaTable)))
		{
			UILabel obj = (UILabel)LuaScriptMgr.GetUnityObject(L, 1, typeof(UILabel));
			Vector2 arg0 = LuaScriptMgr.GetVector2(L, 2);
			string o = obj.GetWordAtPosition(arg0);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 2 && LuaScriptMgr.CheckTypes(L, 1, typeof(UILabel), typeof(LuaTable)))
		{
			UILabel obj = (UILabel)LuaScriptMgr.GetUnityObject(L, 1, typeof(UILabel));
			Vector3 arg0 = LuaScriptMgr.GetVector3(L, 2);
			string o = obj.GetWordAtPosition(arg0);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: UILabel.GetWordAtPosition");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetWordAtCharacterIndex(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		UILabel obj = (UILabel)LuaScriptMgr.GetUnityObject(L, 1, typeof(UILabel));
		int arg0 = (int)LuaScriptMgr.GetNumber(L, 2);
		string o = obj.GetWordAtCharacterIndex(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetUrlAtPosition(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 2 && LuaScriptMgr.CheckTypes(L, 1, typeof(UILabel), typeof(LuaTable)))
		{
			UILabel obj = (UILabel)LuaScriptMgr.GetUnityObject(L, 1, typeof(UILabel));
			Vector2 arg0 = LuaScriptMgr.GetVector2(L, 2);
			string o = obj.GetUrlAtPosition(arg0);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 2 && LuaScriptMgr.CheckTypes(L, 1, typeof(UILabel), typeof(LuaTable)))
		{
			UILabel obj = (UILabel)LuaScriptMgr.GetUnityObject(L, 1, typeof(UILabel));
			Vector3 arg0 = LuaScriptMgr.GetVector3(L, 2);
			string o = obj.GetUrlAtPosition(arg0);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: UILabel.GetUrlAtPosition");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetUrlAtCharacterIndex(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		UILabel obj = (UILabel)LuaScriptMgr.GetUnityObject(L, 1, typeof(UILabel));
		int arg0 = (int)LuaScriptMgr.GetNumber(L, 2);
		string o = obj.GetUrlAtCharacterIndex(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetCharacterIndex(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 3);
		UILabel obj = (UILabel)LuaScriptMgr.GetUnityObject(L, 1, typeof(UILabel));
		int arg0 = (int)LuaScriptMgr.GetNumber(L, 2);
		KeyCode arg1 = (KeyCode)LuaScriptMgr.GetNetObject(L, 3, typeof(KeyCode));
		int o = obj.GetCharacterIndex(arg0,arg1);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int PrintOverlay(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 7);
		UILabel obj = (UILabel)LuaScriptMgr.GetUnityObject(L, 1, typeof(UILabel));
		int arg0 = (int)LuaScriptMgr.GetNumber(L, 2);
		int arg1 = (int)LuaScriptMgr.GetNumber(L, 3);
		UIGeometry arg2 = (UIGeometry)LuaScriptMgr.GetNetObject(L, 4, typeof(UIGeometry));
		UIGeometry arg3 = (UIGeometry)LuaScriptMgr.GetNetObject(L, 5, typeof(UIGeometry));
		Color arg4 = LuaScriptMgr.GetColor(L, 6);
		Color arg5 = LuaScriptMgr.GetColor(L, 7);
		obj.PrintOverlay(arg0,arg1,arg2,arg3,arg4,arg5);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnFill(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 4);
		UILabel obj = (UILabel)LuaScriptMgr.GetUnityObject(L, 1, typeof(UILabel));
		BetterList<Vector3> arg0 = (BetterList<Vector3>)LuaScriptMgr.GetNetObject(L, 2, typeof(BetterList<Vector3>));
		BetterList<Vector2> arg1 = (BetterList<Vector2>)LuaScriptMgr.GetNetObject(L, 3, typeof(BetterList<Vector2>));
		BetterList<Color32> arg2 = (BetterList<Color32>)LuaScriptMgr.GetNetObject(L, 4, typeof(BetterList<Color32>));
		obj.OnFill(arg0,arg1,arg2);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ApplyOffset(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 3);
		UILabel obj = (UILabel)LuaScriptMgr.GetUnityObject(L, 1, typeof(UILabel));
		BetterList<Vector3> arg0 = (BetterList<Vector3>)LuaScriptMgr.GetNetObject(L, 2, typeof(BetterList<Vector3>));
		int arg1 = (int)LuaScriptMgr.GetNumber(L, 3);
		Vector2 o = obj.ApplyOffset(arg0,arg1);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ApplyShadow(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 8);
		UILabel obj = (UILabel)LuaScriptMgr.GetUnityObject(L, 1, typeof(UILabel));
		BetterList<Vector3> arg0 = (BetterList<Vector3>)LuaScriptMgr.GetNetObject(L, 2, typeof(BetterList<Vector3>));
		BetterList<Vector2> arg1 = (BetterList<Vector2>)LuaScriptMgr.GetNetObject(L, 3, typeof(BetterList<Vector2>));
		BetterList<Color32> arg2 = (BetterList<Color32>)LuaScriptMgr.GetNetObject(L, 4, typeof(BetterList<Color32>));
		int arg3 = (int)LuaScriptMgr.GetNumber(L, 5);
		int arg4 = (int)LuaScriptMgr.GetNumber(L, 6);
		float arg5 = (float)LuaScriptMgr.GetNumber(L, 7);
		float arg6 = (float)LuaScriptMgr.GetNumber(L, 8);
		obj.ApplyShadow(arg0,arg1,arg2,arg3,arg4,arg5,arg6);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CalculateOffsetToFit(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		UILabel obj = (UILabel)LuaScriptMgr.GetUnityObject(L, 1, typeof(UILabel));
		string arg0 = LuaScriptMgr.GetLuaString(L, 2);
		int o = obj.CalculateOffsetToFit(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetCurrentProgress(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		UILabel obj = (UILabel)LuaScriptMgr.GetUnityObject(L, 1, typeof(UILabel));
		obj.SetCurrentProgress();
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetCurrentPercent(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		UILabel obj = (UILabel)LuaScriptMgr.GetUnityObject(L, 1, typeof(UILabel));
		obj.SetCurrentPercent();
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetCurrentSelection(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		UILabel obj = (UILabel)LuaScriptMgr.GetUnityObject(L, 1, typeof(UILabel));
		obj.SetCurrentSelection();
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Wrap(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);
		if (count == 3)
		{
			UILabel obj = (UILabel)LuaScriptMgr.GetUnityObject(L, 1, typeof(UILabel));
			string arg0 = LuaScriptMgr.GetLuaString(L, 2);
			string arg1 = null;
			bool o = obj.Wrap(arg0,out arg1);
			LuaScriptMgr.Push(L, o);
			LuaScriptMgr.Push(L, arg1);
			return 2;
		}
		else if (count == 4)
		{
			UILabel obj = (UILabel)LuaScriptMgr.GetUnityObject(L, 1, typeof(UILabel));
			string arg0 = LuaScriptMgr.GetLuaString(L, 2);
			string arg1 = null;
			int arg2 = (int)LuaScriptMgr.GetNumber(L, 4);
			bool o = obj.Wrap(arg0,out arg1,arg2);
			LuaScriptMgr.Push(L, o);
			LuaScriptMgr.Push(L, arg1);
			return 2;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: UILabel.Wrap");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UpdateNGUIText(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		UILabel obj = (UILabel)LuaScriptMgr.GetUnityObject(L, 1, typeof(UILabel));
		obj.UpdateNGUIText();
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

