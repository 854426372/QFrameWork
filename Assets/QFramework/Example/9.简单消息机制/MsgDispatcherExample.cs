using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using QFrameWork;
#if UNITY_EDITOR
using UnityEditor;
#endif


public class MsgDispatcherExample : MonoBehaviour
{
#if UNITY_EDITOR
    [UnityEditor.MenuItem("QFramework/Example/8 简单消息机制", false, 8)]
#endif
    static void MenuClick()
    {
        MsgDispatcher.RegisteredMsgs("消息1", MsgReceived);
        MsgDispatcher.RegisteredMsgs("消息1", MsgReceived);
        MsgDispatcher.Send("消息1", "Hello Word");
        MsgDispatcher.UnRegisteredMsg("消息1", MsgReceived);
        MsgDispatcher.Send("消息1", "Hello");
    }
    private static void MsgReceived(object data)
    {
        Debug.LogFormat("消息1:{0}", data);
    }


}
