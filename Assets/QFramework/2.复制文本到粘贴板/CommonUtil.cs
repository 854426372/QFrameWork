using System;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif


namespace QFrameWork
{
    public partial class CommonUtil
    {
        public static void CopyText(string theStr)
        {
            GUIUtility.systemCopyBuffer = theStr;
        }
        public static string GenerateEnlishDateTime()
        {
            return DateTime.Now.ToString("yyyy_MM_dd_HH_mm");
        }
        public static string GenerateChineseDateTime()
        {
            return DateTime.Now.ToString("yyyy年MM月dd日HH:mm");
        }
        public static string Week()
        {
            string[] weekdays = { "星期日", "星期一", "星期二", "星期三", "星期四", "星期五", "星期六" };
            string week = weekdays[Convert.ToInt32(DateTime.Now.DayOfWeek)];
            return week;
        }
#if UNITY_EDITOR
        [MenuItem("QFramework/2 打印并复制时间/1.中文格式", false, 2)]
        public static void CopeNowTimeChinese()
        {
            string NowTime = CommonUtil.GenerateChineseDateTime() + "_" + CommonUtil.Week(); ;
            CommonUtil.CopyText(NowTime);
            Debug.Log(NowTime);
        }
        [MenuItem("QFramework/2 打印并复制时间/2.英文格式", false, 2)]
        public static void CopeNowTimeEnglish()
        {
            string NowTime = CommonUtil.GenerateEnlishDateTime() + "_" + DateTime.Now.DayOfWeek;
            Debug.Log(NowTime);
            CommonUtil.CopyText(NowTime);
        }
#endif
    }

}