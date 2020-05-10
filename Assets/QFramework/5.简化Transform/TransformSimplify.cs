using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

namespace QFrameWork
{
    public partial class TransformSimplify : MonoBehaviour
    {
        public static void SetIdentity(Transform theTransform)
        {
            theTransform.localRotation = Quaternion.identity;
            theTransform.localScale = Vector3.zero;
            theTransform.localPosition = Vector3.zero;
        }
        public static void SetLocalPosX(Transform theTransfrom, float X)
        {
            Vector3 localPos = theTransfrom.position;
            localPos.x = X;
            theTransfrom.localPosition = localPos;
        }
        public static void SetLocalPosY(Transform theTransfrom, float Y)
        {
            Vector3 localPos = theTransfrom.position;
            localPos.y = Y;
            theTransfrom.localPosition = localPos;
        }
        public static void SetLocalPosZ(Transform theTransfrom, float Z)
        {
            Vector3 localPos = theTransfrom.position;
            localPos.z = Z;
            theTransfrom.localPosition = localPos;
        }
        public static void SetLocalPosXY(Transform theTransfrom, float X, float Y)
        {
            Vector3 localPos = theTransfrom.position;
            localPos.x = X;
            localPos.y = Y;
            theTransfrom.localPosition = localPos;
        }
        public static void SetLocalPosXZ(Transform theTransfrom, float X, float Z)
        {
            Vector3 localPos = theTransfrom.position;
            localPos.x = X;
            localPos.z = Z;
            theTransfrom.localPosition = localPos;
        }
        public static void SetLocalPosYZ(Transform theTransfrom, float Y, float Z)
        {
            Vector3 localPos = theTransfrom.position;
            localPos.y = Y;
            localPos.z = Z;
            theTransfrom.localPosition = localPos;
        }


#if UNITY_EDITOR
        [MenuItem("QFramework/5 Transform API简化/1.赋值优化",false,5)]
#endif
        public static void MenuitemClicked()
        {
            GameObject Go = new GameObject("Transform");
            SetLocalPosX(Go.transform, 10);
        }
#if UNITY_EDITOR
        [MenuItem("QFramework/5 Transform API简化/2.重置Transform", false, 5)]
#endif
        public static void MenuitemClickedPos()
        {
            GameObject go = new GameObject("Transform重置");
            SetIdentity(go.transform);
        }
       
    }
}