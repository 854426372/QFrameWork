using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// 场景管理器
/// </summary>
public class LevelManager : MonoBehaviour
{
    private static List<string> mLevelNames;
    public static int Index { get; set; }
    public static void Init(List<string> levelName)
    {
        Index = 0;
        mLevelNames = levelName;
    }
    public static void LoadCurrent()
    {
        SceneManager.LoadScene(mLevelNames[Index]);
    }
    public static void LoadNext()
    {
        Index++;
        if (Index >= mLevelNames.Count)
        {
            Index = 0;
            Debug.Log("回到第一个场景");
        }
        SceneManager.LoadScene(mLevelNames[Index]);
    }
}
