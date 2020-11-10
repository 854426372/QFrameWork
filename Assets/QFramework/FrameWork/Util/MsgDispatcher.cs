using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace QFrameWork
{
    /// <summary>
    /// 简单消息机制的管理类
    /// </summary>
    public class MsgDispatcher
    {
        private static Dictionary<string, Action<object>> RegisteredMasgDic = new Dictionary<string, Action<object>>();
        /// <summary>
        /// 注册消息
        /// </summary>
        /// <param name="msgName">消息名称</param>
        /// <param name="OnMsgReceived">要注册的方法名</param>
        public static void RegisteredMsgs(string msgName, Action<object> OnMsgReceived)
        {
            if (!RegisteredMasgDic.ContainsKey(msgName))
            {
                RegisteredMasgDic.Add(msgName, _=> { });
            }
            RegisteredMasgDic[msgName] += OnMsgReceived;
        }
        /// <summary>
        /// 注销全部引用相同的消息
        /// </summary>
        /// <param name="msgName">消息名称</param>
        public static void UnRegisteredMsgAll(string msgName)
        {
            RegisteredMasgDic.Remove(msgName);
        }
        /// <summary>
        /// 注销单个消息
        /// </summary>
        /// <param name="msgName">消息引用名称</param>
        /// <param name="OnMsgReceived">要注销的方法名</param>
        public static void UnRegisteredMsg(string msgName, Action<object> OnMsgReceived)
        {
            RegisteredMasgDic[msgName] -= OnMsgReceived;
        }
        /// <summary>
        /// 发送消息
        /// </summary>
        /// <param name="msgName">消息名称</param>
        /// <param name="data">参数</param>
        public static void Send(string msgName, object data)
        {
            if (RegisteredMasgDic.ContainsKey(msgName))
            {
                RegisteredMasgDic[msgName](data);
            }
        }

    }
}