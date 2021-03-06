﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class TipsManagerWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(TipsManager), typeof(System.Object));
		L.RegFunction("ShowTips", ShowTips);
		L.RegFunction("New", _CreateTipsManager);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("showing", get_showing, set_showing);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateTipsManager(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				TipsManager obj = new TipsManager();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: TipsManager.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ShowTips(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1)
			{
				string arg0 = ToLua.CheckString(L, 1);
				TipsManager.ShowTips(arg0);
				return 0;
			}
			else if (count == 2)
			{
				string arg0 = ToLua.CheckString(L, 1);
				object arg1 = ToLua.ToVarObject(L, 2);
				TipsManager.ShowTips(arg0, arg1);
				return 0;
			}
			else if (count == 3)
			{
				string arg0 = ToLua.CheckString(L, 1);
				object arg1 = ToLua.ToVarObject(L, 2);
				float arg2 = (float)LuaDLL.luaL_checknumber(L, 3);
				TipsManager.ShowTips(arg0, arg1, arg2);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: TipsManager.ShowTips");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_showing(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushboolean(L, TipsManager.showing);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_showing(IntPtr L)
	{
		try
		{
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			TipsManager.showing = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

