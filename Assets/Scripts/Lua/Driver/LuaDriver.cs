using UnityEngine;
using System.Collections;
using LuaInterface;

public class LuaDriver
{
    public LuaScriptMgr ScriptMgr;

    protected object result;

    public LuaDriver(LuaScriptMgr mgr, string script)
    {
        ScriptMgr = mgr;
        object[] objects = mgr.DoString(script);
        result = objects[0];
    }
}
