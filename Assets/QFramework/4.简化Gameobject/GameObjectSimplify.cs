using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

namespace QFrameWork
{
    public partial class GameObjectSimplify : MonoBehaviour
    {
        public static void Show(GameObject go)
        {
            go.SetActive(true);
        }
        public static void Hide(GameObject Go)
        {
            Go.SetActive(false);
        }

#if UNITY_EDITOR
        [MenuItem("QFramework/4 Gameobject API简化/1.显示隐藏",false,4)]
#endif
        public static void Menuitem()
        {
            GameObject go = new GameObject("SimplifyObject");
            GameObjectSimplify.Hide(go);
        }

    }
}