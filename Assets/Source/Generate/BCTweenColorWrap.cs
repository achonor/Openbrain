﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class BCTweenColorWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(BCTweenColor), typeof(BCUITweener));
		L.RegFunction("Begin", Begin);
		L.RegFunction("SetStartToCurrentValue", SetStartToCurrentValue);
		L.RegFunction("SetEndToCurrentValue", SetEndToCurrentValue);
		L.RegFunction("SetCurrentValueToStart", SetCurrentValueToStart);
		L.RegFunction("SetCurrentValueToEnd", SetCurrentValueToEnd);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("from", get_from, set_from);
		L.RegVar("to", get_to, set_to);
		L.RegVar("UGUIMode", get_UGUIMode, set_UGUIMode);
		L.RegVar("uguiImages", get_uguiImages, set_uguiImages);
		L.RegVar("uguiTexts", get_uguiTexts, set_uguiTexts);
		L.RegVar("uguiCanvasRens", get_uguiCanvasRens, set_uguiCanvasRens);
		L.RegVar("uguiModeRenders", get_uguiModeRenders, set_uguiModeRenders);
		L.RegVar("value", get_value, set_value);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Begin(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.CheckObject(L, 1, typeof(UnityEngine.GameObject));
			float arg1 = (float)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.Color arg2 = ToLua.ToColor(L, 3);
			BCTweenColor o = BCTweenColor.Begin(arg0, arg1, arg2);
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetStartToCurrentValue(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			BCTweenColor obj = (BCTweenColor)ToLua.CheckObject<BCTweenColor>(L, 1);
			obj.SetStartToCurrentValue();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetEndToCurrentValue(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			BCTweenColor obj = (BCTweenColor)ToLua.CheckObject<BCTweenColor>(L, 1);
			obj.SetEndToCurrentValue();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetCurrentValueToStart(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			BCTweenColor obj = (BCTweenColor)ToLua.CheckObject<BCTweenColor>(L, 1);
			obj.SetCurrentValueToStart();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetCurrentValueToEnd(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			BCTweenColor obj = (BCTweenColor)ToLua.CheckObject<BCTweenColor>(L, 1);
			obj.SetCurrentValueToEnd();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int op_Equality(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Object arg0 = (UnityEngine.Object)ToLua.ToObject(L, 1);
			UnityEngine.Object arg1 = (UnityEngine.Object)ToLua.ToObject(L, 2);
			bool o = arg0 == arg1;
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_from(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			BCTweenColor obj = (BCTweenColor)o;
			UnityEngine.Color ret = obj.from;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index from on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_to(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			BCTweenColor obj = (BCTweenColor)o;
			UnityEngine.Color ret = obj.to;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index to on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_UGUIMode(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			BCTweenColor obj = (BCTweenColor)o;
			bool ret = obj.UGUIMode;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index UGUIMode on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_uguiImages(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			BCTweenColor obj = (BCTweenColor)o;
			UnityEngine.UI.Image[] ret = obj.uguiImages;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index uguiImages on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_uguiTexts(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			BCTweenColor obj = (BCTweenColor)o;
			UnityEngine.UI.Text[] ret = obj.uguiTexts;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index uguiTexts on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_uguiCanvasRens(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			BCTweenColor obj = (BCTweenColor)o;
			UnityEngine.CanvasRenderer[] ret = obj.uguiCanvasRens;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index uguiCanvasRens on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_uguiModeRenders(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			BCTweenColor obj = (BCTweenColor)o;
			UnityEngine.Renderer[] ret = obj.uguiModeRenders;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index uguiModeRenders on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_value(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			BCTweenColor obj = (BCTweenColor)o;
			UnityEngine.Color ret = obj.value;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index value on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_from(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			BCTweenColor obj = (BCTweenColor)o;
			UnityEngine.Color arg0 = ToLua.ToColor(L, 2);
			obj.from = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index from on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_to(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			BCTweenColor obj = (BCTweenColor)o;
			UnityEngine.Color arg0 = ToLua.ToColor(L, 2);
			obj.to = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index to on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_UGUIMode(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			BCTweenColor obj = (BCTweenColor)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.UGUIMode = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index UGUIMode on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_uguiImages(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			BCTweenColor obj = (BCTweenColor)o;
			UnityEngine.UI.Image[] arg0 = ToLua.CheckObjectArray<UnityEngine.UI.Image>(L, 2);
			obj.uguiImages = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index uguiImages on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_uguiTexts(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			BCTweenColor obj = (BCTweenColor)o;
			UnityEngine.UI.Text[] arg0 = ToLua.CheckObjectArray<UnityEngine.UI.Text>(L, 2);
			obj.uguiTexts = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index uguiTexts on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_uguiCanvasRens(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			BCTweenColor obj = (BCTweenColor)o;
			UnityEngine.CanvasRenderer[] arg0 = ToLua.CheckObjectArray<UnityEngine.CanvasRenderer>(L, 2);
			obj.uguiCanvasRens = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index uguiCanvasRens on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_uguiModeRenders(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			BCTweenColor obj = (BCTweenColor)o;
			UnityEngine.Renderer[] arg0 = ToLua.CheckObjectArray<UnityEngine.Renderer>(L, 2);
			obj.uguiModeRenders = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index uguiModeRenders on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_value(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			BCTweenColor obj = (BCTweenColor)o;
			UnityEngine.Color arg0 = ToLua.ToColor(L, 2);
			obj.value = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index value on a nil value");
		}
	}
}
