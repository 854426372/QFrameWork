using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace QFrameWork
{
    public partial class MonoBehaviourSimplify : MonoBehaviour
    {
        public void Show()
        {
            GameObjectSimplify.Show(gameObject);
        }
        public void Hide()
        {
            GameObjectSimplify.Hide(gameObject);
        }
        public void Identity()
        {
            TransformSimplify.SetIdentity(transform);
        }
    }
    public class Hide : MonoBehaviourSimplify
    {
        private void Awake()
        {
            Hide();
        }
#if UNITY_EDITOR
        [UnityEditor.MenuItem("QFramework/11 MonoBehaviour 简化", false, 11)]
        static void MenumClick()
        {
            UnityEditor.EditorApplication.isPlaying = true;
            var gameObj = new GameObject("Hide");
            gameObj.AddComponent<Hide>();
        }

        protected override void OnBeforeDestroy()
        {
        }
#endif
    }
}