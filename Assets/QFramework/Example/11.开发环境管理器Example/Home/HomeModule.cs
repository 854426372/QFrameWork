using QFrameWork;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace QFrameWork
{
    public class HomeModule : DEManager
    {
        protected override void LaunchInDevelopingMode()
        {
            Debug.Log("home场景开发环境");
            //TODO开发逻辑
        }
        protected override void LaunchInTestMode()
        {
            Debug.Log("home场景测试环境");
            // 测试逻辑
            // 加载资源
            // 初始化 SDK
            // 点击开始游戏
            GameModule.LoadModule("Game");
        }
        protected override void LaunchInProductionMode()
        {
            Debug.Log("home场景生产环境");
            // ⽣产逻辑
            // 加载资源
            // 初始化 SDK
            // 点击开始游戏
            GameModule.LoadModule("Game");
            
        }

    }
}
