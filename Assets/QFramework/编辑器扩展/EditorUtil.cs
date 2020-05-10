using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
#if UNITY_EDITOR
using UnityEditor;
#endif

namespace QFrameWork
{
    public partial class EditorUtil
    {
#if UNITY_EDITOR
        public static void CallMenuItem(string menuitem)
        {
            EditorApplication.ExecuteMenuItem(menuitem);
        }
        public static void OpenInFolder(string folderPath)
        {
            Application.OpenURL("file:///" + folderPath);
        }
        //打开网页
        public static void OpenInWebsite(string WebsiteUrl)
        {
            Application.OpenURL(WebsiteUrl);
        }
        //打包
        public static void ExportPackage(string assetPathName, string fileName)
        {
            AssetDatabase.ExportPackage(assetPathName, fileName, ExportPackageOptions.Recurse);
        }
#endif
    }
}