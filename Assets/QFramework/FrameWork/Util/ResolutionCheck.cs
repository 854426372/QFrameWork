using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace QFrameWork
{
    /// <summary>
    /// 屏幕分辩率的工具类
    /// </summary>
    public class ResolutionCheck : MonoBehaviour
    {
        public static bool IsPadResolution()
        {
            return InAspectRange(4.0f / 3);
        }
        public static bool Is16MoreThan9()
        {
            return InAspectRange(16f / 9);
        }
        public static bool Is21MoreThan9()
        {
            return InAspectRange(21f / 9);
        }
        public static float GetAspectRatio()
        {
            bool IsLandscape = Screen.width > Screen.height;
            return IsLandscape ? (float)Screen.width / Screen.height : (float)Screen.height / Screen.width;
        }
        public static bool InAspectRange(float dstAspectRatio)
        {
            float aspect = GetAspectRatio();
            return aspect > (dstAspectRatio - 0.05f) && aspect < (dstAspectRatio + 0.05f);
        }
    }
}