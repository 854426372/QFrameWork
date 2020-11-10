using QFrameWork;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class GUIExample : MonoBehaviourSimplify
{

#if UNITY_EDITOR
    [UnityEditor.MenuItem("QFramework/Example/10 加载UI界面和卸载", false, 10)]
    public static void MenuClick()
    {
        UnityEditor.EditorApplication.isPlaying = true;
        new GameObject("homePanel").AddComponent<GUIExample>();
    }
#endif
    private void Start()
    {
        GUIManager.SetResolution(1024, 768, 0.5f);
        GameObject go = GUIManager.LoadPanel("GUIExample", UILayer.Common);
        Delay(8.0f, () => { GUIManager.UnLoadPanel("GUIExample"); });
    }

    protected override void OnBeforeDestroy()
    {
    }
}
