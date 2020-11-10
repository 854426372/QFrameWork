using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace QFrameWork
{
    public abstract class Pool<T> : IPool<T>
    {
        protected Stack<T> mCacheStack = new Stack<T>();
        protected IObjectFactory<T> mFactory;
        protected int mMaxCount = 5;
        /// <summary>
        /// Gets the current count;
        /// </summary>
        /// <value> the current count</value>
        public int CurCount
        {
            get { return mCacheStack.Count; }
        }
        public virtual T Allocate()
        {
            //Create:
            //pop：移除并返回顶部的一个对象
            return mCacheStack.Count == 0 ? mFactory.Create() : mCacheStack.Pop();
        }
        public virtual T[] GetStack()
        {
            return mCacheStack.ToArray();
        }
        public abstract bool Recycle(T obj);
    }
}