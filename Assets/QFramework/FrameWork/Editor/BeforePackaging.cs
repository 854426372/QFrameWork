using System.Collections;
#if UNITY_EDITOR
using UnityEditor.Build;
using UnityEditor.Build.Reporting;
#endif
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///在打包之前会调用改脚本
/// </summary>
#if UNITY_EDITOR
public class BeforePackaging :IPreprocessBuildWithReport
{
    public int callbackOrder { get => 0; }

    public void OnPreprocessBuild(BuildReport report)
    {
        Debug.Log("在打包之前调用脚本");
    }

}
#endif
