using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace QFrameWork
{
    /// <summary>
    /// unity GameObject内置方法的简化
    /// </summary>
    public static class GameObjectExtension
    {
        /// <summary>
        /// 显示自身物体
        /// </summary>
        /// <param name="go"></param>
        public static void Show(this GameObject go)
        {
            go.SetActive(true);
        }
        /// <summary>
        /// 隐藏自身
        /// </summary>
        /// <param name="Go"></param>
        public static void Hide(this GameObject Go)
        {
            Go.SetActive(false);
        }
       /// <summary>
       /// 显示自身
       /// </summary>
       /// <param name="tran"></param>
        public static void Show(this Transform tran)
        {
            tran.gameObject.SetActive(true);
        }
        /// <summary>
        /// 隐藏自身
        /// </summary>
        /// <param name="tran"></param>
        public static void Hide(this Transform tran)
        {
            tran.gameObject.SetActive(false);
        }
        /// <summary>
        /// mono类的支持显示
        /// </summary>
        /// <param name="tran"></param>
        public static void Show(this MonoBehaviour tran)
        {
            tran.gameObject.SetActive(true);
        }
        /// <summary>
        /// mono类的支持隐藏
        /// </summary>
        /// <param name="tran"></param>
        public static void Hide(this MonoBehaviour tran)
        {
            tran.gameObject.SetActive(false);
        }
        /// <summary>
        /// 设置自身重置
        /// </summary>
        /// <param name="theTransform"></param>
        public static void SetIdentity(this GameObject thegameobject)
        {
            thegameobject.transform.localRotation = Quaternion.identity;
            thegameobject.transform.localScale = Vector3.zero;
            thegameobject.transform.localPosition = Vector3.zero;
        }
        /// <summary>
        /// transform 给自身添加子物体
        /// </summary>
        /// <param name="tran"></param>
        /// <param name="childTran"></param>
        public static void AddChild(this GameObject tran, Transform childTran)
        {
            tran.transform.AddChild(childTran);
        }
    }
}