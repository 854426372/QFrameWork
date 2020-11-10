using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace QFrameWork
{
    public class HideExample : MonoBehaviour
    {
#if UNITY_EDITOR
        [UnityEditor.MenuItem("QFramework/Example/7 MonoBehaviour 简化/1 Hide GameObject", false, 7)]
        static void MenumClick()
        {
            UnityEditor.EditorApplication.isPlaying = true;
            var gameObj = new GameObject("Hide");
            gameObj.AddComponent<Hide>();
        }
#endif
    }
}