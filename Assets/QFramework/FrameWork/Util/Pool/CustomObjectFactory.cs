using System;

namespace QFrameWork
{
    class CustomObjectFactory<T> : IObjectFactory<T>
    {
        protected Func<T> mFactoryMethod;
        public CustomObjectFactory(Func<T> factoryMethd)
        {
            mFactoryMethod = factoryMethd;
        }
        public T Create()
        {
            return mFactoryMethod();
        }
    }
}