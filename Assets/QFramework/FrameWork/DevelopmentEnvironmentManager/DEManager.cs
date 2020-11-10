using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace QFrameWork
{
    /// <summary>
    /// 环境模式
    /// </summary>
    public enum EnvironmentMode 
    { 
        Developing, //开发环境
        Test,       //测试环境
        Production, //生产环境
    }
    /// <summary>
    /// 主的管理器
    /// </summary>
    public abstract class DEManager : MonoBehaviour
    {
        public EnvironmentMode Mode;
        private static EnvironmentMode mShareMode ;
        private static bool mModeSetted = false;
        private void Start()
        {
            if (!mModeSetted)
            {
                mShareMode = Mode;
                mModeSetted = true;
                
            }
            switch (mShareMode)
            {
                case EnvironmentMode.Developing:
                    LaunchInDevelopingMode();
                    break;
                case EnvironmentMode.Test:
                    LaunchInTestMode();
                    break;
                case EnvironmentMode.Production:
                    LaunchInProductionMode();
                    break;
                default:
                    break;
            }
        }
        /// <summary>
        /// 开发模式
        /// </summary>
        protected abstract void LaunchInDevelopingMode();
        /// <summary>
        /// 测试模式
        /// </summary>
        protected abstract void LaunchInTestMode();
        /// <summary>
        /// 投入生产模式
        /// </summary>
        protected abstract void LaunchInProductionMode();

        /// <summary>
        /// 加载某一个场景的方法（带扩展为场景管理器）
        /// </summary>
        /// <param name="scenesName"></param>
        protected static void LoadModule(string  scenesName)
        {
            SceneManager.LoadScene(scenesName);
        }
    }
}
