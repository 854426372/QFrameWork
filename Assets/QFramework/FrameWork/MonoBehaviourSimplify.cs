using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace QFrameWork
{
    public abstract partial class MonoBehaviourSimplify : MonoBehaviour
    {
        #region  时间相关  Time
        /// <summary>
        /// 延时调用
        /// </summary>
        /// <param name="seconds">延时时间</param>
        /// <param name="OnFinished">需要延时的方法</param>
        public void Delay(float seconds, Action OnFinished)
        {
            StartCoroutine(DelayCoroution(seconds, OnFinished));
        }
        private static IEnumerator DelayCoroution(float seconds, Action OnFinished)
        {
            yield return new WaitForSeconds(seconds);
            OnFinished();
        }
        #endregion
        #region 简单消息机制    MsgDis
        /// <summary>
        /// 消息类的集合
        /// </summary>
        List<MsgRecord> mMsgRecord = new List<MsgRecord>();
        /// <summary>
        /// 消息类
        /// </summary>
        private class MsgRecord
        {
            /// <summary>
            /// 私有的构造方法，不让外部去new 出来
            /// </summary>
            private MsgRecord() { }
            static Stack<MsgRecord> mMsgRecordPool = new Stack<MsgRecord>();
            /// <summary>
            /// 分配一个消息出来（msgName = 消息的名字； Action<Object> = 要注册的消息）
            /// </summary>
            /// <returns></returns>
            public static MsgRecord AllLocate(string msgName, Action<object> OnMsgReceived)
            {
                MsgRecord retMsgRecord = null;
                retMsgRecord = mMsgRecordPool.Count > 0 ? mMsgRecordPool.Pop() : new MsgRecord();
                retMsgRecord.Name = msgName;
                retMsgRecord.OnMsgReceived = OnMsgReceived;
                return retMsgRecord;
            }
            /// <summary>
            /// 回收一条消息
            /// </summary>
            public void Recycle()
            {
                Name = null;
                OnMsgReceived = null;
                mMsgRecordPool.Push(this);//将自身设置为空，而后向stack顶部添加进去
            }
            /// <summary>
            /// 消息的名字
            /// </summary>
            public string Name;
            /// <summary>
            /// 注册的消息
            /// </summary>
            public Action<object> OnMsgReceived;
        }
        /// <summary>
        /// 注册消息（string = 消息的名字 ； Action<object> = 要注册的消息）
        /// </summary>
        protected void RegisterMsg(string msgName, Action<object> OnMsgReceived)
        {
            MsgDispatcher.RegisteredMsgs(msgName, OnMsgReceived);
            mMsgRecord.Add(MsgRecord.AllLocate(msgName, OnMsgReceived));
        }
        /// <summary>
        /// 发送消息，调用之前注册此消息的方法（string = 消息名称 ； object 消息事件的数据）
        /// </summary>
        protected void SendMsg(string msgName, object data)
        {
            MsgDispatcher.Send(msgName, data);
        }
        /// <summary>
        /// 注销所有同名的消息（string = 之前注册消息）
        /// </summary>
        /// <param name="msgName"></param>
        protected void UnRegisterMsg(string msgName)
        {
            List<MsgRecord> selectedRecords = mMsgRecord.FindAll(recorder => recorder.Name == msgName);
            selectedRecords.ForEach(records =>
            {
                MsgDispatcher.UnRegisteredMsg(records.Name, records.OnMsgReceived);
                mMsgRecord.Remove(records);
                records.Recycle();
            });
            selectedRecords.Clear();
        }
        /// <summary>
        /// 移除单个消息名字的单个注册消息事件（string = 消息名字； action<object> = 之前注册的消息，如方法）
        /// </summary>
        protected void UnRegisterMsg(string msgName, Action<object> OnMsgReceived)
        {
            List<MsgRecord> selectedRecord = mMsgRecord.FindAll(record => record.Name == msgName && record.OnMsgReceived == OnMsgReceived);
            selectedRecord.ForEach(records =>
            {
                MsgDispatcher.UnRegisteredMsg(records.Name, records.OnMsgReceived);
                mMsgRecord.Remove(records);
                records.Recycle();
            });
            selectedRecord.Clear();
        }

        #endregion
        private void OnDestroy()
        {
            OnBeforeDestroy();
            foreach (var item in mMsgRecord)
            {
                MsgDispatcher.UnRegisteredMsg(item.Name, item.OnMsgReceived);
                item.Recycle();
            }
            mMsgRecord.Clear();
        }
        protected abstract void OnBeforeDestroy();
    }
}