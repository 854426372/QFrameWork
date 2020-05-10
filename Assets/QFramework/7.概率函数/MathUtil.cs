using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

namespace QFrameWork
{
    public partial class MathUtil : MonoBehaviour
    {
#if UNITY_EDITOR
        [MenuItem("QFramework/7 输入百分比判断是否命中概率",false,7)]
#endif
        public static void MenuClick()
        {
            Debug.Log(Percent(20));
        }
        public static bool Percent(int percent)
        {
            return Random.Range(0, 100) <= percent;
        }
    }
}