using UnityEngine;


namespace QFrameWork
{
    /// <summary>
    /// 数学相关计算工具类
    /// </summary>
    public partial class MathUtil : MonoBehaviour
    {
        //判断返回是否在百分比内
        public static bool Percent(int percent)
        {
            return Random.Range(0, 100) <= percent;
        }
        //获取参数内的随机一个值
        public static T GetRandomValueFrom<T>(params T[] values)
        {
            return values[Random.Range(0, values.Length)];
        }
    }
}