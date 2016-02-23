using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CSharpInterface
{
    public static GameObject GetPanel()
    {
        return GameObject.Find("Canvas/Panel");
    }

    public static GameObject CreateButton(UnityEngine.Events.UnityAction e, string name = "")
    {
        GameObject go = GameObject.Instantiate(Resources.Load("UI/Button")) as GameObject;
        if (!string.IsNullOrEmpty(name))
        {
            go.name = name;
        }
        go.transform.parent = GetPanel().transform;
        go.transform.localPosition = Vector3.zero;
        go.transform.localScale = Vector3.one;
        Button button = go.GetComponent<Button>();
        button.onClick.AddListener(e);
        return go;
    }
}
