using QFrameWork;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace QFrameWork
{
    public class AudioExample : MonoBehaviourSimplify
    {
#if UNITY_EDITOR
        [UnityEditor.MenuItem("QFramework/Example/11 加载音源进入场景", false, 11)]
        private static void MenuItem()
        {
            UnityEditor.EditorApplication.isPlaying = true;
            new GameObject("AudioExample").AddComponent<AudioExample>();
        }

#endif
        // Start is called before the first frame update
        void Start()
        {
            Debug.Log("音乐管理器已经集成到Manager内，搜索BaseManager的子类来查看！");
            AudioManager.Instance.PlaySoundBg(AudioManager.Bg);
        }
        private void Update() {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                AudioManager.Instance.PlaySoundNormal(AudioManager.Shoot);
            }
        }
        protected override void OnBeforeDestroy()
        {
           
        }
    }
}