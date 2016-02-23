using UnityEngine;
using System.Collections;
using LuaInterface;

public class HelloWorld : MonoBehaviour {

	private string script = @"
            print(TestClass.number)
        ";
	
	// Use this for initialization
	void Start () {
		LuaScriptMgr lua = new LuaScriptMgr();
		lua.Start();
		lua.DoString(script);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
