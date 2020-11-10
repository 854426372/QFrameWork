using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace QFrameWork
{
    public class SingletonExample : Singleton<SingletonExample>
    {
#if UNITY_EDITOR
        [UnityEditor.MenuItem("QFramework/Example/14 单例模式演示", false, 14)]
#endif
        private static void MenumClick()
        {
            var initInstance = SingletonExample._Instance;
            initInstance = SingletonExample._Instance;
        }
        private SingletonExample()
        {
            Debug.Log("SingletonExample ctor");
        }
    }
}