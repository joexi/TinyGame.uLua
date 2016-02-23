using UnityEngine;
using System.Collections;

public class LuaView : MonoBehaviour {
    public LuaViewDriver viewDriver;

    public TextAsset Script;

    void Awake () {
        LuaScriptMgr mgr = new LuaScriptMgr();
        mgr.Start();
        viewDriver = new LuaViewDriver(mgr, Script.text);
        viewDriver.Awake();
    }

	void Start () {
        viewDriver.Start();
	}
	
	void Update () {
        viewDriver.Update();
	}

    void OnGUI()
    {
        viewDriver.OnGUI();
    }

    void OnEnable()
    {
        viewDriver.OnEnable();
    }

    void OnDisable()
    {
        viewDriver.OnDisable();
    }

    void OnDestroy()
    {
        viewDriver.OnDestroy();
    }
}
