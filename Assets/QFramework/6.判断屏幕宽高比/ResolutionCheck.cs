using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

namespace QFrameWork
{
    public partial class ResolutionCheck : MonoBehaviour
    {
#if UNITY_EDITOR
        [MenuItem("QFramework/6 判断屏幕宽高比",false,6)]
#endif
        public static void MenuClicked()
        {
            Debug.Log(GetAspectRatio());
            Debug.Log(IsPadResolution() ? "是Pad" : "不是Pad");
            Debug.Log(Is16MoreThan9() ? "是16/9" : "不是16/9");
            Debug.Log(Is21MoreThan9() ? "是21/9" : "不是21/9");
        }
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