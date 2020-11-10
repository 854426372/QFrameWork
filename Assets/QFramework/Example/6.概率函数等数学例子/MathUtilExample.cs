using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif
namespace QFrameWork {
    public partial class MathUtilExample : MonoBehaviour
    {
#if UNITY_EDITOR
        [MenuItem("QFramework/Example/6 MathUtil/1 输入百分比判断是否命中概率", false, 6)]
#endif
        public static void MenuClick()
        {
            Debug.Log(MathUtil.Percent(20));
        }
#if UNITY_EDITOR
        [MenuItem("QFramework/Example/6 MathUtil/2 从容器中随机取出一个值", false, 6)]
#endif
        public static void GetRandomClick()
        {
            Debug.Log(MathUtil.GetRandomValueFrom("第一个", "第二个", "第三个"));
            Debug.Log(MathUtil.GetRandomValueFrom(1, 25, 6, 3));
            Debug.Log(MathUtil.GetRandomValueFrom(0.2f, 0.5f, 0.8f));

        }
    }
}
