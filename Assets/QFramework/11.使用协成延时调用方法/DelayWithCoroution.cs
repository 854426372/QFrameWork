using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace QFrameWork
{
    public partial class MonoBehaviourSimplify
    {
        public void Delay(float seconds, Action OnFinished)
        {
            StartCoroutine(DelayCoroution(seconds, OnFinished));
        }
        private static IEnumerator DelayCoroution(float seconds, Action OnFinished)
        {
            yield return new WaitForSeconds(seconds);
            OnFinished();
        }
    }
    public class DelayWithCoroution : MonoBehaviourSimplify
    {
        private void Start()
        {
            Delay(3, () =>
            {
                UnityEditor.EditorApplication.isPlaying = false;
            });
        }
#if UNITY_EDITOR
        [UnityEditor.MenuItem("QFramework/12 延时调用某个函数", false, 12)]
#endif
        private static void MenumClick()
        {
            UnityEditor.EditorApplication.isPlaying = true;
            new GameObject("DelayWithCoroution").AddComponent<DelayWithCoroution>();
        }

        protected override void OnBeforeDestroy()
        {
            throw new NotImplementedException();
        }
    }
}