using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CSharpInterface
{
    public static GameObject GetPanel()
    {
        return GameObject.Find(RESOURCE_PATH.MAIN_PANEL);
    }

    public static GameObject CreateButton(UnityEngine.Events.UnityAction e, string name = "")
    {
        GameObject go = GameObject.Instantiate(Resources.Load(RESOURCE_PATH.BUTTON)) as GameObject;
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

    public static GameObject CreateSprite(string path)
    {
        GameObject go = CreateObject(RESOURCE_PATH.SPRITE);
        Image image = go.GetComponent<Image>();
        image.sprite = Resources.Load<GameObject>(path).GetComponent<SpriteRenderer>().sprite;
        return go;
    }

    public static GameObject CreateTexture(string path)
    {
        GameObject go = CreateObject(RESOURCE_PATH.TEXTURE);
        RawImage image = go.GetComponent<RawImage>();
        image.texture = Resources.Load(path) as Texture2D;
        image.SetNativeSize();
        return go;
    }   

    public static GameObject CreateObject(string path) 
    {
        GameObject go = GameObject.Instantiate(Resources.Load(path)) as GameObject;
        go.transform.parent = GetPanel().transform;
        go.transform.localPosition = Vector3.zero;
        go.transform.localScale = Vector3.one;
        return go;
    }
}
