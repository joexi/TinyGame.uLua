﻿using System;
using UnityEngine;
using LuaInterface;
using Object = UnityEngine.Object;

public class AudioClipWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("GetData", GetData),
			new LuaMethod("SetData", SetData),
			new LuaMethod("Create", Create),
			new LuaMethod("New", _CreateAudioClip),
			new LuaMethod("GetClassType", GetClassType),
			new LuaMethod("__eq", Lua_Eq),
		};

		LuaField[] fields = new LuaField[]
		{
			new LuaField("length", get_length, null),
			new LuaField("samples", get_samples, null),
			new LuaField("channels", get_channels, null),
			new LuaField("frequency", get_frequency, null),
			new LuaField("isReadyToPlay", get_isReadyToPlay, null),
		};

		LuaScriptMgr.RegisterLib(L, "UnityEngine.AudioClip", typeof(AudioClip), regs, fields, typeof(Object));
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateAudioClip(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 0)
		{
			AudioClip obj = new AudioClip();
			LuaScriptMgr.Push(L, obj);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: AudioClip.New");
		}

		return 0;
	}

	static Type classType = typeof(AudioClip);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_length(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		AudioClip obj = (AudioClip)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name length");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index length on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.length);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_samples(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		AudioClip obj = (AudioClip)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name samples");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index samples on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.samples);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_channels(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		AudioClip obj = (AudioClip)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name channels");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index channels on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.channels);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_frequency(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		AudioClip obj = (AudioClip)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name frequency");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index frequency on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.frequency);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_isReadyToPlay(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		AudioClip obj = (AudioClip)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name isReadyToPlay");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index isReadyToPlay on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.isReadyToPlay);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetData(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 3);
		AudioClip obj = (AudioClip)LuaScriptMgr.GetUnityObjectSelf(L, 1, "AudioClip");
		float[] objs0 = LuaScriptMgr.GetArrayNumber<float>(L, 2);
		int arg1 = (int)LuaScriptMgr.GetNumber(L, 3);
		obj.GetData(objs0,arg1);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetData(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 3);
		AudioClip obj = (AudioClip)LuaScriptMgr.GetUnityObjectSelf(L, 1, "AudioClip");
		float[] objs0 = LuaScriptMgr.GetArrayNumber<float>(L, 2);
		int arg1 = (int)LuaScriptMgr.GetNumber(L, 3);
		obj.SetData(objs0,arg1);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Create(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 6)
		{
			string arg0 = LuaScriptMgr.GetLuaString(L, 1);
			int arg1 = (int)LuaScriptMgr.GetNumber(L, 2);
			int arg2 = (int)LuaScriptMgr.GetNumber(L, 3);
			int arg3 = (int)LuaScriptMgr.GetNumber(L, 4);
			bool arg4 = LuaScriptMgr.GetBoolean(L, 5);
			bool arg5 = LuaScriptMgr.GetBoolean(L, 6);
			AudioClip o = AudioClip.Create(arg0,arg1,arg2,arg3,arg4,arg5);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 7)
		{
			string arg0 = LuaScriptMgr.GetLuaString(L, 1);
			int arg1 = (int)LuaScriptMgr.GetNumber(L, 2);
			int arg2 = (int)LuaScriptMgr.GetNumber(L, 3);
			int arg3 = (int)LuaScriptMgr.GetNumber(L, 4);
			bool arg4 = LuaScriptMgr.GetBoolean(L, 5);
			bool arg5 = LuaScriptMgr.GetBoolean(L, 6);
			AudioClip.PCMReaderCallback arg6 = null;
			LuaTypes funcType7 = LuaDLL.lua_type(L, 7);

			if (funcType7 != LuaTypes.LUA_TFUNCTION)
			{
				 arg6 = (AudioClip.PCMReaderCallback)LuaScriptMgr.GetNetObject(L, 7, typeof(AudioClip.PCMReaderCallback));
			}
			else
			{
				LuaFunction func = LuaScriptMgr.GetLuaFunction(L, 7);
				arg6 = (param0) =>
				{
					int top = func.BeginPCall();
					LuaScriptMgr.PushArray(L, param0);
					func.PCall(top, 1);
					func.EndPCall(top);
				};
			}

			AudioClip o = AudioClip.Create(arg0,arg1,arg2,arg3,arg4,arg5,arg6);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 8)
		{
			string arg0 = LuaScriptMgr.GetLuaString(L, 1);
			int arg1 = (int)LuaScriptMgr.GetNumber(L, 2);
			int arg2 = (int)LuaScriptMgr.GetNumber(L, 3);
			int arg3 = (int)LuaScriptMgr.GetNumber(L, 4);
			bool arg4 = LuaScriptMgr.GetBoolean(L, 5);
			bool arg5 = LuaScriptMgr.GetBoolean(L, 6);
			AudioClip.PCMReaderCallback arg6 = null;
			LuaTypes funcType7 = LuaDLL.lua_type(L, 7);

			if (funcType7 != LuaTypes.LUA_TFUNCTION)
			{
				 arg6 = (AudioClip.PCMReaderCallback)LuaScriptMgr.GetNetObject(L, 7, typeof(AudioClip.PCMReaderCallback));
			}
			else
			{
				LuaFunction func = LuaScriptMgr.GetLuaFunction(L, 7);
				arg6 = (param0) =>
				{
					int top = func.BeginPCall();
					LuaScriptMgr.PushArray(L, param0);
					func.PCall(top, 1);
					func.EndPCall(top);
				};
			}

			AudioClip.PCMSetPositionCallback arg7 = null;
			LuaTypes funcType8 = LuaDLL.lua_type(L, 8);

			if (funcType8 != LuaTypes.LUA_TFUNCTION)
			{
				 arg7 = (AudioClip.PCMSetPositionCallback)LuaScriptMgr.GetNetObject(L, 8, typeof(AudioClip.PCMSetPositionCallback));
			}
			else
			{
				LuaFunction func = LuaScriptMgr.GetLuaFunction(L, 8);
				arg7 = (param0) =>
				{
					int top = func.BeginPCall();
					LuaScriptMgr.Push(L, param0);
					func.PCall(top, 1);
					func.EndPCall(top);
				};
			}

			AudioClip o = AudioClip.Create(arg0,arg1,arg2,arg3,arg4,arg5,arg6,arg7);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: AudioClip.Create");
		}

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

