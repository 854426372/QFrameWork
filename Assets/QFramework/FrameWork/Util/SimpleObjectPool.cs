using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace QFrameWork
{
    public class SimpleObjectPool<T> : Pool<T>
    {
        readonly Action<T> mResetMethod;
        public SimpleObjectPool(Func<T> factoryMethod, Action<T> resetMethod = null, int initCount = 0)
        {
            mFactory = new CustomObjectFactory<T>(factoryMethod);
            mResetMethod = resetMethod;
            for (var i = 0; i < initCount; i++)
            {
                mCacheStack.Push(mFactory.Create());
            }
        }
        public override bool Recycle(T obj)
        {
            if (mResetMethod != null)
            {
                mResetMethod(obj);
            }
            mCacheStack.Push(obj);
            return true;
        }

    }
}