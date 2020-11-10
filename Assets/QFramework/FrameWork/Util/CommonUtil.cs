using System;
using UnityEngine;

namespace QFrameWork
{
    /// <summary>
    /// 公共功能工具类
    /// </summary>
    public partial class CommonUtil
    {
        public static void CopyText(string theStr)
        {
            GUIUtility.systemCopyBuffer = theStr;
        }
        #region 一、获取电脑时间的工具方法
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
        #endregion
    }

}