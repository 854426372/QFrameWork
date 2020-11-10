using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

namespace QFrameWork
{ 
    public class OpenWebsite :MonoBehaviour
    {
#if UNITY_EDITOR
        [MenuItem("QFramework/Example/ 2.打开百度", false, 2)]
        private static void MenuItem()
        {
            EditorUtil.OpenInWebsite("www.baidu.com");
        }
#endif
    }
}