using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using QFrameWork;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class FrameworkExample : MonoBehaviourSimplify
{
#if UNITY_EDITOR
    [MenuItem("QFramework/Example/9 框架示例消息发送", false, 9)]
    private static void MenuClick2()
    {
        EditorApplication.isPlaying = true;
        new GameObject("MsgReceiverObj").AddComponent<FrameworkExample>();
    }
#endif
    private void Awake()
    {
        RegisterMsg("Do", DoSomeThing);
        RegisterMsg("Do", DoSomeThing);
        RegisterMsg("Do1", _ => { });
        RegisterMsg("Do2", _ => { });
        RegisterMsg("Do3", _ => { });

    }
    IEnumerator Start()
    {
        SendMsg("Do", "hello");
        yield return new WaitForSeconds(1.0f);
        SendMsg("Do", "hello1");
        Destroy(this.gameObject);
    }
    void DoSomeThing(object data)
    {
        Debug.LogFormat("Received Do msg:{0}", data);
    }
    protected override void OnBeforeDestroy()
    {
    }
}
