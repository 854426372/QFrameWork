using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

namespace QFrameWork
{
    public partial class ResolutionCheckExample : MonoBehaviour
    {
#if UNITY_EDITOR
        [MenuItem("QFramework/Example/ 3.判断屏幕宽高比", false, 3)]
#endif
        public static void MenuClicked()
        {
            Debug.Log(ResolutionCheck.GetAspectRatio());
            Debug.Log(ResolutionCheck.IsPadResolution() ? "是Pad" : "不是Pad");
            Debug.Log(ResolutionCheck.Is16MoreThan9() ? "是16/9" : "不是16/9");
            Debug.Log(ResolutionCheck.Is21MoreThan9() ? "是21/9" : "不是21/9");
        }
       
    }
}