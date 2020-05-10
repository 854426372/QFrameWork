using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.CompilerServices;
#if UNITY_EDITOR
using UnityEditor;
#endif

namespace QFrameWork
{
    public partial class MathUtil : MonoBehaviour
    {
#if UNITY_EDITOR
        [MenuItem("QFramework/9 从若干个值中随机取出一个值", false, 9)]
#endif
        public static void GetRandomClick()
        {
            Debug.Log(GetRandomValueFrom("1", "2","我是你"));
            Debug.Log(GetRandomValueFrom(1,25,6,3));
            Debug.Log(GetRandomValueFrom(0.2f,0.5f,0.8f));
        }
        public static T GetRandomValueFrom<T>(params T[] values)
        {
            return values[Random.Range(0, values.Length)];
        }
    }
}