using UnityEditor;
#if UNITY_EDITOR
using UnityEngine;
public class BeforPackageExample : MonoBehaviour
{
    [MenuItem("QFramework/Example/16 打包之前调用脚本", false, 16)]
    private static void MenuItem()
    {
        Debug.Log("打开“BeforePackaging”脚本，在里面添加逻辑，将在打包之前执行，比如更新版本时间");
    }
}
#endif
