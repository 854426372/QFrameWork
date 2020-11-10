using System;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QFrameWork
{
    class PoolExample 
    {
        private class Fish :MonoBehaviour
        {
            private void Awake()
            {
                Debug.Log("asd");
                GameObject go = new GameObject("fish");
            }
            private void Start()
            {
                
            }
        }
#if UNITY_EDITOR
        [UnityEditor.MenuItem("QFramework/Example/12 Pool对象池实现", false, 12)]
#endif
        private static void MenuClick()
        {
            var fishPool = new SimpleObjectPool<Fish>(() => new Fish(), null, 10);
            Debug.LogFormat("fishPool.CurCount:{0}",fishPool.CurCount);
            Fish fishOne = fishPool.Allocate();
            //Debug.LogFormat("fishPool.curCount:{0}", fishPool.CurCount);
            //fishPool.Recycle(fishOne);
            //Debug.LogFormat("fishPool.CurCount:{0}", fishPool.CurCount);
            //for (int i = 0; i < 10; i++)
            //{
            //    GameObject fish = fishPool.Allocate();
            //}
            //Debug.LogFormat("Fishpool.curCount:{0}", fishPool.CurCount);
        }
        public static GameObject CreatGo()
        {
            GameObject go = new GameObject("pool");
            go.SetActive(false);
            return go;
        }
    }
}
