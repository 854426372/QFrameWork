using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace QFrameWork
{
    /// <summary>
    /// 层级管理的枚举
    /// </summary>
    /// 用来管理UI的层级
    public enum UILayer
    {
        Bg,
        Common,
        Top
    }
    /// <summary>
    /// GUI的管理类（待重构以及合并）
    /// </summary>
    public class GUIManager : MonoBehaviour
    {
        private static GameObject mPrivateUiRoot;
        public static GameObject UIRoot
        {
            get
            {
                if (mPrivateUiRoot == null)
                {
                    mPrivateUiRoot = Instantiate(Resources.Load<GameObject>("UIRoot"));
                    mPrivateUiRoot.name = "UIRoot";
                }
                return mPrivateUiRoot;
            }
        }                                                                                                          
        private static Dictionary<string, GameObject> mPanelsDict = new Dictionary<string, GameObject>();          //存储UI面板的字典


        /// <summary>
        /// 移除某一个面板
        /// </summary>
        /// <param name="panelName">面板的名字</param>
        public static void UnLoadPanel(string panelName)
        {
            if (mPanelsDict.ContainsKey(panelName))
            {
                Destroy(mPanelsDict[panelName]);
            }
        }
        /// <summary>
        /// 加载面板
        /// </summary>
        /// <param name="panelName">面板名字</param>
        /// <param name="uILayer">UI层级的名字，使用UILayer类</param>
        /// <returns></returns>
        public static GameObject LoadPanel(string panelName, UILayer uILayer)
        {
            var panel = Instantiate(Resources.Load<GameObject>(panelName));
            panel.transform.SetParent(UIRoot.transform.Find(uILayer.ToString()));
            var panelRectTrans = panel.transform as RectTransform;
            mPanelsDict.Add(panelName, panel);
            panelRectTrans.anchorMin = Vector2.zero;                                                                //矩形右上角规范化位置
            panelRectTrans.anchorMax = Vector2.one;
            panelRectTrans.anchoredPosition3D = Vector3.zero;                                                       //当前锚点的位置
            panelRectTrans.offsetMin = Vector2.zero;                                                                //偏移量
            panelRectTrans.offsetMax = Vector2.zero;
            return panel;
        }
        /// <summary>
        /// 设置canvas的屏幕分辨率和适配宽高
        /// </summary>
        /// <param name="width">分辨率宽宽</param>
        /// <param name="heigh">分辨率高</param>
        /// <param name="matchWidthOrHeight">分辨率的适配比例</param>
        public static void SetResolution(float width, float heigh, float matchWidthOrHeight)
        {
            var canvasScaler = UIRoot.GetComponent<CanvasScaler>();
            canvasScaler.referenceResolution = new Vector2(width, heigh);
            canvasScaler.matchWidthOrHeight = matchWidthOrHeight;
        }
    }
}