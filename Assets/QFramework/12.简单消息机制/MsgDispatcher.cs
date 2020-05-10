using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace QFrameWork
{
    public class MsgDispatcher
    {
        private static Dictionary<string, Action<object>> RegisteredMasgDic = new Dictionary<string, Action<object>>();
        public static void RegisteredMsgs(string msgName, Action<object> OnMsgReceived)
        {
            if (!RegisteredMasgDic.ContainsKey(msgName))
            {
                RegisteredMasgDic.Add(msgName, _=> { });
            }
            RegisteredMasgDic[msgName] += OnMsgReceived;
        }
        public static void UnRegisteredMsgAll(string msgName)
        {
            RegisteredMasgDic.Remove(msgName);
        }
        public static void UnRegisteredMsg(string msgName, Action<object> OnMsgReceived)
        {
            RegisteredMasgDic[msgName] -= OnMsgReceived;
        }
        public static void Send(string msgName, object data)
        {
            if (RegisteredMasgDic.ContainsKey(msgName))
            {

                RegisteredMasgDic[msgName](data);
            }
        }
#if UNITY_EDITOR
        [UnityEditor.MenuItem("QFramework/13 简单消息机制", false, 13)]
#endif
        static void MenuClick()
        {
            RegisteredMsgs("消息1", MsgReceived);
            RegisteredMsgs("消息1", MsgReceived);
            Send("消息1", "Hello Word");
            UnRegisteredMsg("消息1", MsgReceived);
            Send("消息1", "Hello");
        }
        private  static void MsgReceived(object data)
        {
            Debug.LogFormat("消息1:{0}", data);
        }
    }
}