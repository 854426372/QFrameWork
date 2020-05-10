using System;
using UnityEngine;
using JetBrains.Annotations;
#if UNITY_EDITOR
using UnityEditor;
#endif

namespace QFrameWork {
    class Exporter
    {
        private static string GenerateUnityPackageName()
        {
            return "QFramework" + DateTime.Now.ToString("yyyyMMdd_HH");
        }
#if UNITY_EDITOR
        [MenuItem("QFramework/1 输出QFramework的UnityPackage %e", false, 1)]
#endif
        public static void MenuitemClicked()
        {
            string generatePackageName = Exporter.GenerateUnityPackageName();
            EditorUtil.ExportPackage("Assets/QFramework", generatePackageName);
            EditorUtil.OpenInFolder(Application.dataPath);
        }
    }
}