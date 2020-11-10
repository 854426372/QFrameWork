using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace QFrameWork
{
    public class LevelExample : MonoBehaviourSimplify
    {
#if UNITY_EDITOR
        [UnityEditor.MenuItem("QFramework/Example/13 关卡管理器", false, 13)]
        private static void MenuClick()
        {
            UnityEditor.EditorApplication.isPlaying = true;
            new GameObject().AddComponent<LevelExample>();
        }
#endif

        protected override void OnBeforeDestroy()
        {
        }

        private void Start()
        {
            DontDestroyOnLoad(this);
            LevelManager.Init(new List<string>
            {
                "Game",
                "Level",
                "Home",
            });
            LevelManager.LoadCurrent();
            Delay(10f, LevelManager.LoadNext);

        }
    }
}