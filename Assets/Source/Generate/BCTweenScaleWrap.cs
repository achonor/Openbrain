﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class BCTweenScaleWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(BCTweenScale), typeof(BCUITweener));
		L.RegFunction("Begin", Begin);
		L.RegFunction("SetStartToCurrentValue", SetStartToCurrentValue);
		L.RegFunction("SetEndToCurrentValue", SetEndToCurrentValue);
		L.RegFunction("SetCurrentValueToStart", SetCurrentValueToStart);
		L.RegFunction("SetCurrentValueToEnd", SetCurrentValueToEnd);
		L.RegFunction("Play", Play);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("from", get_from, set_from);
		L.RegVar("to", get_to, set_to);
		L.RegVar("fromIsCurrent", get_fromIsCurrent, set_fromIsCurrent);
		L.RegVar("RelativeScale", get_RelativeScale, set_RelativeScale);
		L.RegVar("mTrans", get_mTrans, set_mTrans);
		L.RegVar("cachedTransform", get_cachedTransform, null);
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
			UnityEngine.Vector3 arg2 = ToLua.ToVector3(L, 3);
			BCTweenScale o = BCTweenScale.Begin(arg0, arg1, arg2);
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
			BCTweenScale obj = (BCTweenScale)ToLua.CheckObject<BCTweenScale>(L, 1);
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
			BCTweenScale obj = (BCTweenScale)ToLua.CheckObject<BCTweenScale>(L, 1);
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
			BCTweenScale obj = (BCTweenScale)ToLua.CheckObject<BCTweenScale>(L, 1);
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
			BCTweenScale obj = (BCTweenScale)ToLua.CheckObject<BCTweenScale>(L, 1);
			obj.SetCurrentValueToEnd();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Play(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1)
			{
				BCTweenScale obj = (BCTweenScale)ToLua.CheckObject<BCTweenScale>(L, 1);
				obj.Play();
				return 0;
			}
			else if (count == 2)
			{
				BCTweenScale obj = (BCTweenScale)ToLua.CheckObject<BCTweenScale>(L, 1);
				bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
				obj.Play(arg0);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: BCTweenScale.Play");
			}
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
			BCTweenScale obj = (BCTweenScale)o;
			UnityEngine.Vector3 ret = obj.from;
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
			BCTweenScale obj = (BCTweenScale)o;
			UnityEngine.Vector3 ret = obj.to;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index to on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_fromIsCurrent(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			BCTweenScale obj = (BCTweenScale)o;
			bool ret = obj.fromIsCurrent;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index fromIsCurrent on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_RelativeScale(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			BCTweenScale obj = (BCTweenScale)o;
			bool ret = obj.RelativeScale;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index RelativeScale on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_mTrans(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			BCTweenScale obj = (BCTweenScale)o;
			UnityEngine.Transform ret = obj.mTrans;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index mTrans on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_cachedTransform(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			BCTweenScale obj = (BCTweenScale)o;
			UnityEngine.Transform ret = obj.cachedTransform;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index cachedTransform on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_value(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			BCTweenScale obj = (BCTweenScale)o;
			UnityEngine.Vector3 ret = obj.value;
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
			BCTweenScale obj = (BCTweenScale)o;
			UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
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
			BCTweenScale obj = (BCTweenScale)o;
			UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
			obj.to = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index to on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_fromIsCurrent(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			BCTweenScale obj = (BCTweenScale)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.fromIsCurrent = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index fromIsCurrent on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_RelativeScale(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			BCTweenScale obj = (BCTweenScale)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.RelativeScale = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index RelativeScale on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_mTrans(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			BCTweenScale obj = (BCTweenScale)o;
			UnityEngine.Transform arg0 = (UnityEngine.Transform)ToLua.CheckObject<UnityEngine.Transform>(L, 2);
			obj.mTrans = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index mTrans on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_value(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			BCTweenScale obj = (BCTweenScale)o;
			UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
			obj.value = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index value on a nil value");
		}
	}
}

