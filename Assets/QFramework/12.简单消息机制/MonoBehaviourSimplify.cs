using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace QFrameWork
{
    public abstract partial class MonoBehaviourSimplify
    {
        Dictionary<string, Action<object>> mMsgBehaviourSimplifyDic = new Dictionary<string, Action<object>>();
        protected void RegisterMsg(string msgName,Action<object> OnMsgReceived)
        {
            MsgDispatcher.RegisteredMsgs(msgName, OnMsgReceived);
            mMsgBehaviourSimplifyDic.Add(msgName,OnMsgReceived);
        }
        private void OnDestroy()
        {
            OnBeforeDestroy();
            foreach (var item in mMsgBehaviourSimplifyDic)
            {
                MsgDispatcher.UnRegisteredMsg(item.Key, item.Value);
            }
            mMsgBehaviourSimplifyDic.Clear();
        }
        protected abstract void OnBeforeDestroy();
    }
}