using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

namespace QFrameWork
{
    public class TransformSimplifyExample : MonoBehaviour
    {
#if UNITY_EDITOR
        [MenuItem("QFramework/Example/4 Transform API简化/1赋值优化", false, 4)]
#endif
        public static void MenuitemClicked()
        {
            GameObject Go = new GameObject("Transform");
            GameObject child = new GameObject("child");
            Go.transform.SetIdentity();
            Go.transform.AddChild(child.transform);
            Go.transform.SetLocalPosX(10);
        }
#if UNITY_EDITOR
        [MenuItem("QFramework/Example/4 Transform API简化/2重置Transform", false, 4)]
#endif
        public static void MenuitemClickedPos()
        {
            GameObject go = new GameObject("Transform重置");
            go.SetIdentity();
        }
#if UNITY_EDITOR
        [MenuItem("QFramework/Example/4 Transform API简化/3设置父物体", false, 4)]
#endif
        public static void MenuClicked()
        {
            GameObject parentTrans = GameObject.CreatePrimitive(PrimitiveType.Cube).gameObject;
            parentTrans.name = "Parent";
            var childTrans = new GameObject("Child").transform;
            parentTrans.AddChild(childTrans);
        }
    }
}