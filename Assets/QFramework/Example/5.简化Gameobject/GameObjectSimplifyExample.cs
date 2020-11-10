using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.CompilerServices;
#if UNITY_EDITOR
using UnityEditor;
#endif

namespace QFrameWork
{
    public partial class GameObjectSimplifyExample : MonoBehaviour
    {

#if UNITY_EDITOR
        [MenuItem("QFramework/Example/5 Gameobject API简化/1.显示隐藏",false,5)]
#endif
        public static void Menuitem()
        {
            GameObject go = new GameObject("SimplifyObject");
            go.Hide();
            
        }
        private void Start()
        {
        }

    }
}