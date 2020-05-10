using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

namespace QFrameWork
{
    public class OpenWebsite : MonoBehaviour
    {
#if UNITY_EDITOR

        [MenuItem("QFramework/3 打开百度网页", false, 3)]
        public static void OpenWebClick()
        {
            EditorUtil.OpenInWebsite("http://www.baidu.com");
        }
#endif
    }
}