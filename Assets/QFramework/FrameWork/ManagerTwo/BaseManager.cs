using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace QFrameWork
{
    /// <summary>
    /// 所有管理类的基类
    /// </summary>
    public class BaseManager
    {
        protected GameRoot gameRoot;
        public BaseManager(GameRoot root)
        {
            gameRoot = root;
        }
        public virtual void OnInit() { }
        public virtual void OnUpdata() { }
        public virtual void OnDestory() { }
    }
}