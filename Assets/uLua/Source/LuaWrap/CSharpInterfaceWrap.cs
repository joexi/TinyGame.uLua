using System;
using UnityEngine;
using LuaInterface;

public class CSharpInterfaceWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("GetPanel", GetPanel),
			new LuaMethod("CreateButton", CreateButton),
			new LuaMethod("New", _CreateCSharpInterface),
			new LuaMethod("GetClassType", GetClassType),
		};

		LuaField[] fields = new LuaField[]
		{
		};

		LuaScriptMgr.RegisterLib(L, "CSharpInterface", typeof(CSharpInterface), regs, fields, typeof(object));
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateCSharpInterface(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 0)
		{
			CSharpInterface obj = new CSharpInterface();
			LuaScriptMgr.PushObject(L, obj);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: CSharpInterface.New");
		}

		return 0;
	}

	static Type classType = typeof(CSharpInterface);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetPanel(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 0);
		GameObject o = CSharpInterface.GetPanel();
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CreateButton(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		UnityEngine.Events.UnityAction arg0 = null;
		LuaTypes funcType1 = LuaDLL.lua_type(L, 1);

		if (funcType1 != LuaTypes.LUA_TFUNCTION)
		{
			 arg0 = (UnityEngine.Events.UnityAction)LuaScriptMgr.GetNetObject(L, 1, typeof(UnityEngine.Events.UnityAction));
		}
		else
		{
			LuaFunction func = LuaScriptMgr.GetLuaFunction(L, 1);
			arg0 = () =>
			{
				func.Call();
			};
		}

		string arg1 = LuaScriptMgr.GetLuaString(L, 2);
		GameObject o = CSharpInterface.CreateButton(arg0,arg1);
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}

