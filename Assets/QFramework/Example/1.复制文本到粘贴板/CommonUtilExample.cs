using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
#if UNITY_EDITOR
using UnityEditor;
#endif
namespace QFrameWork
{
    public class CommonUtilExample : MonoBehaviour
    {
#if UNITY_EDITOR
        [MenuItem("QFramework/Example/ 1.打印并复制时间/1.中文格式", false, 1)]
        public static void CopeNowTimeChinese()
        {
            string NowTime = CommonUtil.GenerateChineseDateTime() + "_" + CommonUtil.Week(); ;
            CommonUtil.CopyText(NowTime);
            Debug.Log(NowTime);
        }
        [MenuItem("QFramework/Example/1.打印并复制时间/2.英文格式", false, 1)]
        public static void CopeNowTimeEnglish()
        {
            string NowTime = CommonUtil.GenerateEnlishDateTime() + "_" + DateTime.Now.DayOfWeek;
            Debug.Log(NowTime);
            CommonUtil.CopyText(NowTime);
        }
#endif
    }
}