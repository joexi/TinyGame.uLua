using UnityEngine;
using System.Collections;
using LuaInterface;


public class LuaViewDriver : LuaDriver{

    public LuaFunction LuaAwake;
    public LuaFunction LuaStart;
    public LuaFunction LuaUpdate;
    public LuaFunction LuaOnGUI;
    public LuaFunction LuaOnEnable;
    public LuaFunction LuaOnDisable;
    public LuaFunction LuaOnDestroy;
    public LuaFunction LuaOnTriggerEnter;
    public LuaFunction LuaOnTriggerExit;

    public LuaViewDriver(LuaScriptMgr mgr, string script) : base(mgr, script){
        LuaTable lt = (LuaTable)result;
        LuaStart = lt.RawGetFunc("Start");
        LuaUpdate = lt.RawGetFunc("Update");
        LuaOnEnable = lt.RawGetFunc("OnEnable");
        LuaOnDisable = lt.RawGetFunc("OnDisable");
        LuaOnDestroy = lt.RawGetFunc("OnDestroy");
        LuaOnTriggerEnter = lt.RawGetFunc("OnTriggerEnter");
        LuaOnTriggerExit = lt.RawGetFunc("OnTriggerExit");
	}

    public void Awake()
    {
        if (LuaAwake != null)
        {
            LuaAwake.Call();
        }
    }

    public void Start()
    {
        if (LuaStart != null)
        {
            LuaStart.Call();
        }
    }

    public void Update()
    {
        if (LuaUpdate != null)
        {
            LuaUpdate.Call();
        }
    }

    public void OnGUI()
    {
        if (LuaOnGUI != null)
        {
            LuaOnGUI.Call();
        }
    }

    public void OnEnable()
    {
        if (LuaOnEnable != null)
        {
            LuaOnEnable.Call();
        }
    }

    public void OnDisable()
    {
        if (LuaOnDisable != null)
        {
            LuaOnDisable.Call();
        }
    }

    public void OnDestroy()
    {
        if (LuaOnDestroy != null)
        {
            LuaOnDestroy.Call();
        }
    }
}
