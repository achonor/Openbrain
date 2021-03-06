﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class ResourceManagerWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(ResourceManager), typeof(UnityEngine.MonoBehaviour));
		L.RegFunction("DestroyResource", DestroyResource);
		L.RegFunction("WWWLoad", WWWLoad);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("Instance", get_Instance, set_Instance);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DestroyResource(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes<ResourceObject>(L, 2))
			{
				ResourceManager obj = (ResourceManager)ToLua.CheckObject<ResourceManager>(L, 1);
				ResourceObject arg0 = (ResourceObject)ToLua.ToObject(L, 2);
				obj.DestroyResource(arg0);
				return 0;
			}
			else if (count == 2 && TypeChecker.CheckTypes<string>(L, 2))
			{
				ResourceManager obj = (ResourceManager)ToLua.CheckObject<ResourceManager>(L, 1);
				string arg0 = ToLua.ToString(L, 2);
				obj.DestroyResource(arg0);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: ResourceManager.DestroyResource");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int WWWLoad(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			ResourceManager obj = (ResourceManager)ToLua.CheckObject<ResourceManager>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			System.Action<byte[]> arg1 = (System.Action<byte[]>)ToLua.CheckDelegate<System.Action<byte[]>>(L, 3);
			obj.WWWLoad(arg0, arg1);
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
	static int get_Instance(IntPtr L)
	{
		try
		{
			ToLua.Push(L, ResourceManager.Instance);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Instance(IntPtr L)
	{
		try
		{
			ResourceManager arg0 = (ResourceManager)ToLua.CheckObject<ResourceManager>(L, 2);
			ResourceManager.Instance = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

