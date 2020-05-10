using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

namespace QFrameWork
{
    public class PartialKeyWord : MonoBehaviour
    {
#if UNITY_EDITOR
        [MenuItem("QFramework/8 Partial关键字",false,8)]
#endif
        public static void MenuClicked()
        {
            var parentTrans =GameObject.CreatePrimitive(PrimitiveType.Cube).transform;
            parentTrans.name = "Parent";
            var childTrans= new GameObject("Child").transform;
            TransformSimplify.AddChild(parentTrans, childTrans);

        }
    }
}