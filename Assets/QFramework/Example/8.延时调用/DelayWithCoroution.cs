using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace QFrameWork
{
    public class DelayWithCoroution : MonoBehaviourSimplify
    {
#if UNITY_EDITOR
        private void Start()
        {
            Delay(3, () =>
            {
                UnityEditor.EditorApplication.isPlaying = false;
            });
        }
        [UnityEditor.MenuItem("QFramework/Example/7 MonoBehaviour 简化/2 延时调用某个函数", false, 7)]
        private static void MenumClick()
        {
            UnityEditor.EditorApplication.isPlaying = true;
            new GameObject("DelayWithCoroution").AddComponent<DelayWithCoroution>();
        }
#endif

        protected override void OnBeforeDestroy()
        {
        }
    }
}