using QFrameWork;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace QFrameWork
{
    public class GameModule : DEManager
    {
        
        protected override void LaunchInDevelopingMode()
        {
            Debug.Log("Game场景开发环境");
            //GUIManager.LoadPanel("HomePanel");
            //TODO开发逻辑
            //加载资源
            //初始化SDK
            //Game的一些准备逻辑（角色选择、准备一些假的数据等等）
        }
        protected override void LaunchInTestMode()
        {
            Debug.Log("Game场景测试环境");
            //TODO正常的生产逻辑
        }
        protected override void LaunchInProductionMode()
        {
            Debug.Log("Game场景生产环境");
            //TODO正常的测试逻辑
        }

    }
}
