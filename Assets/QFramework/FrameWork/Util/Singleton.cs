using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

namespace QFrameWork
{
    public class Singleton<T> where T : Singleton<T>
    {
        protected static T Instance = null;
        protected Singleton() { }
        public static T _Instance
        {
            get
            {
                if (Instance == null)
                {
                    var ctors = typeof(T).GetConstructors(BindingFlags.Instance | BindingFlags.NonPublic);
                    var ctor = Array.Find(ctors, c => c.GetParameters().Length == 0);
                    if (ctor == null)
                    {
                        throw new Exception("Non - public ctor() not found !");
                    }
                    Instance = ctor.Invoke(null) as T;
                }
                return Instance;
            }
        }
    }
}