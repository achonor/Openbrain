﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class GameDataWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(GameData), typeof(System.Object));
		L.RegFunction("LoadConfigs", LoadConfigs);
		L.RegFunction("GetServerConfig", GetServerConfig);
		L.RegFunction("New", _CreateGameData);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("GameConfig", get_GameConfig, set_GameConfig);
		L.RegVar("Gray", get_Gray, set_Gray);
		L.RegVar("Bule", get_Bule, set_Bule);
		L.RegVar("LightRed", get_LightRed, set_LightRed);
		L.RegVar("LightBlue", get_LightBlue, set_LightBlue);
		L.RegVar("Yellow", get_Yellow, set_Yellow);
		L.RegVar("RedBlock", get_RedBlock, set_RedBlock);
		L.RegVar("BlueBlock", get_BlueBlock, set_BlueBlock);
		L.RegVar("GameConfigPath", get_GameConfigPath, set_GameConfigPath);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateGameData(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				GameData obj = new GameData();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: GameData.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LoadConfigs(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			GameData.LoadConfigs();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetServerConfig(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			LitJson.JsonData o = GameData.GetServerConfig();
			ToLua.PushObject(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_GameConfig(IntPtr L)
	{
		try
		{
			ToLua.PushObject(L, GameData.GameConfig);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Gray(IntPtr L)
	{
		try
		{
			ToLua.Push(L, GameData.Gray);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Bule(IntPtr L)
	{
		try
		{
			ToLua.Push(L, GameData.Bule);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_LightRed(IntPtr L)
	{
		try
		{
			ToLua.Push(L, GameData.LightRed);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_LightBlue(IntPtr L)
	{
		try
		{
			ToLua.Push(L, GameData.LightBlue);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Yellow(IntPtr L)
	{
		try
		{
			ToLua.Push(L, GameData.Yellow);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_RedBlock(IntPtr L)
	{
		try
		{
			ToLua.Push(L, GameData.RedBlock);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_BlueBlock(IntPtr L)
	{
		try
		{
			ToLua.Push(L, GameData.BlueBlock);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_GameConfigPath(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, GameData.GameConfigPath);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_GameConfig(IntPtr L)
	{
		try
		{
			LitJson.JsonData arg0 = (LitJson.JsonData)ToLua.CheckObject<LitJson.JsonData>(L, 2);
			GameData.GameConfig = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Gray(IntPtr L)
	{
		try
		{
			UnityEngine.Color arg0 = ToLua.ToColor(L, 2);
			GameData.Gray = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Bule(IntPtr L)
	{
		try
		{
			UnityEngine.Color arg0 = ToLua.ToColor(L, 2);
			GameData.Bule = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_LightRed(IntPtr L)
	{
		try
		{
			UnityEngine.Color arg0 = ToLua.ToColor(L, 2);
			GameData.LightRed = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_LightBlue(IntPtr L)
	{
		try
		{
			UnityEngine.Color arg0 = ToLua.ToColor(L, 2);
			GameData.LightBlue = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Yellow(IntPtr L)
	{
		try
		{
			UnityEngine.Color arg0 = ToLua.ToColor(L, 2);
			GameData.Yellow = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_RedBlock(IntPtr L)
	{
		try
		{
			UnityEngine.Color arg0 = ToLua.ToColor(L, 2);
			GameData.RedBlock = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_BlueBlock(IntPtr L)
	{
		try
		{
			UnityEngine.Color arg0 = ToLua.ToColor(L, 2);
			GameData.BlueBlock = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_GameConfigPath(IntPtr L)
	{
		try
		{
			string arg0 = ToLua.CheckString(L, 2);
			GameData.GameConfigPath = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

