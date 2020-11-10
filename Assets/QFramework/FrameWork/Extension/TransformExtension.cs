using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace QFrameWork
{
    /// <summary>
    /// unity Transform 内置方法的简化类
    /// </summary>
    public static class TransformExtension
    {
        //
        /// <summary>
        /// 设置自身重置
        /// </summary>
        /// <param name="theTransform"></param>
        public static void SetIdentity(this MonoBehaviour theTransform)
        {
            SetIdentity(theTransform.transform);
        }
        /// <summary>
        /// 设置transform重置
        /// </summary>
        /// <param name="theTransform"></param>
        public static void SetIdentity(this Transform theTransform)
        {
            theTransform.localRotation = Quaternion.identity;
            theTransform.localScale = Vector3.zero;
            theTransform.localPosition = Vector3.zero;
        }

        /// <summary>
        /// 设置 自身X local轴的数值(x = 传入的数值)
        /// </summary>
        /// <param name="theTransfrom"></param>
        /// <param name="X"></param>
        public static void SetLocalPosX(this MonoBehaviour theTransfrom, float X)
        {
            SetLocalPosX(theTransfrom.transform,X);
        }
        /// <summary>
        /// 设置Transform local  X轴的数值(x = 传入的数值)
        /// </summary>
        /// <param name="theTransfrom"></param>
        /// <param name="X"></param>
        public static void SetLocalPosX(this Transform theTransfrom, float X)
        {
            Vector3 localPos = theTransfrom.position;
            localPos.x = X;
            theTransfrom.localPosition = localPos;
        }
        /// <summary>
        /// 设置 Transform local 的Y值
        /// </summary>
        /// <param name="theTransfrom"></param>
        /// <param name="Y"></param>
        public static void SetLocalPosY(this Transform theTransfrom, float Y)
        {
            Vector3 localPos = theTransfrom.position;
            localPos.y = Y;
            theTransfrom.localPosition = localPos;
        }
        /// <summary>
        /// 设置Transform local 的Z值
        /// </summary>
        /// <param name="theTransfrom"></param>
        /// <param name="Z"></param>
        public static void SetLocalPosZ(this Transform theTransfrom, float Z)
        {
            Vector3 localPos = theTransfrom.position;
            localPos.z = Z;
            theTransfrom.localPosition = localPos;
        }
       /// <summary>
       /// 设置 transform local 的X Y 值
       /// </summary>
       /// <param name="theTransfrom"></param>
       /// <param name="X"></param>
       /// <param name="Y"></param>
        public static void SetLocalPosXY(this Transform theTransfrom, float X, float Y)
        {
            Vector3 localPos = theTransfrom.position;
            localPos.x = X;
            localPos.y = Y;
            theTransfrom.localPosition = localPos;
        }
        /// <summary>
        /// 设置 transform local 的X Z 值
        /// </summary>
        /// <param name="theTransfrom"></param>
        /// <param name="X"></param>
        /// <param name="Z"></param>
        public static void SetLocalPosXZ(this Transform theTransfrom, float X, float Z)
        {
            Vector3 localPos = theTransfrom.position;
            localPos.x = X;
            localPos.z = Z;
            theTransfrom.localPosition = localPos;
        }
        /// <summary>
        /// 设置 transform local 的 Y Z 值
        /// </summary>
        /// <param name="theTransfrom"></param>
        /// <param name="Y"></param>
        /// <param name="Z"></param>
        public static void SetLocalPosYZ(this Transform theTransfrom, float Y, float Z)
        {
            Vector3 localPos = theTransfrom.position;
            localPos.y = Y;
            localPos.z = Z;
            theTransfrom.localPosition = localPos;
        }

        /// <summary>
        /// transform 给自身添加子物体
        /// </summary>
        /// <param name="tran"></param>
        /// <param name="childTran"></param>
        public static void AddChild(this Transform tran, Transform childTran)
        {
            childTran.SetParent(tran);
        }

    }
}