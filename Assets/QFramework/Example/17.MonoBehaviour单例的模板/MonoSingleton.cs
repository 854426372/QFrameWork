using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace QFrameWork
{
    // public class MonoSingleton<T> : MonoBehaviour where T : MonoSingleton<T>
    // {
    //     protected static T mInstance = null;
    //     protected virtual void OnDestory()
    //     {
    //         mInstance = null;
    //     }
    //     public static T Instance
    //     {
    //         get
    //         {
    //             if (mInstance == null)
    //             {
    //                 mInstance = FindObjectOfType<T>();
    //                 if (FindObjectsOfType<T>().Length > 1)
    //                 {
    //                     Debug.LogWarning("More than 1");
    //                     return mInstance;
    //                 }
    //                 if (mInstance == null)
    //                 {
    //                     var instanceName = typeof(T).Name;
    //                     Debug.LogFormat("Instance Name :{0}", instanceName);
    //                     var instanceObj = GameObject.Find(instanceName);
    //                     if (!instanceObj)
    //                         instanceObj = new GameObject(instanceName);
    //                     mInstance = instanceObj.AddComponent<T>();
    //                     DontDestroyOnLoad(instanceObj);
    //                     Debug.LogFormat("Add New Singleton {0} in Game!",instanceName);
    //                 }
    //                 else
    //                 {
    //                     Debug.LogFormat("Already Exist :{0}", mInstance.name);
    //                 }
    //             }
    //             return mInstance;
    //         }
    //     }
    // }
}