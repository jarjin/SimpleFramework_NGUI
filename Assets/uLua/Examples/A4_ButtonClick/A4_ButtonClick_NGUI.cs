using UnityEngine;
using System.Collections;
using LuaInterface;

public class A4_ButtonClick_NGUI : MonoBehaviour
{
    public UIButton button;

    private string script =
    @"                  
        function doClick(go)
            print('UIButton Click:>>>'..go.name)
        end

        function TestClick(go)                     
            UIEventListener.Get(go).onClick = doClick;
        end
    ";
	// Use this for initialization
	void Start () {
        LuaScriptMgr mgr = new LuaScriptMgr();
        mgr.Start();
        mgr.DoString(script);

        LuaFunction func = mgr.GetLuaFunction("TestClick");
        func.Call(button.gameObject);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
