using System;
using UnityEngine;
using JetBrains.Annotations;
using UnityEditor;

namespace QFrameWork {
    class Exporter
    {
        /// <summary>
        /// 导出包时返回一个包的名字
        /// </summary>
        /// <returns></returns>
        private static string GenerateUnityPackageName()
        {
            return "QFramework" + DateTime.Now.ToString("yyyyMMdd_HH")+".unitypackage";
        }
        [MenuItem("QFramework/Framework/Editor/导出 UnityPackage %e", false, 1)]
        public static void MenuitemClicked()
        {
            string generatePackageName = Exporter.GenerateUnityPackageName();
            EditorUtil.ExportPackage("Assets/QFramework", generatePackageName);
            EditorUtil.OpenInFolder(Application.dataPath);
        }
    }
}