using QFrameWork.Manager;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace QFrameWork
{

    /// <summary>
    /// 音乐管理类
    /// </summary>
    public class AudioManager : MonoBehaviour
    {
        #region  //所有音乐源常量名字
        public const string Bg = "Bg";
        public const string Shoot = "Shoot";

        #endregion  
        private static AudioManager _instance;                   //单例模式
        private AudioSource mBgAudioSource;                      //背景音乐的音源      
        private AudioSource mNormalAudioSource;                  //正常音乐的音源

        public  AudioSource NormalAudioSource                   //正常音乐的音源外部调用属性         
        {
            get{ if(mNormalAudioSource == null)
            {
                mNormalAudioSource = this.gameObject.AddComponent<AudioSource>();
            }
            return mNormalAudioSource;
            }
        } 
        public AudioSource   BgAudioSource                      //背景音乐的音源外部调用属性
        {
            get{ if(mBgAudioSource == null)
            {
                mBgAudioSource = this.gameObject.AddComponent<AudioSource>();
            }
            return mBgAudioSource;
            }
            
        }
        public static AudioManager Instance                      //单例方法
        {
            get
            {
                if(_instance == null){
                    _instance = new GameObject("AudioManager").AddComponent<AudioManager>();
                    DontDestroyOnLoad(_instance);
                }
                return _instance;
            }
        }      
        
        #region 背景音乐
        /// <summary>
        /// 播放背景音乐（string = 要播放的音乐名字）
        /// </summary>
        public void PlaySoundBg(string soundName)
        {
            PlaySound(BgAudioSource, LoadSound(soundName), 0.5f, true);
        }
        /// <summary>
        /// 停止播放背景音乐
        /// </summary>
        public void BGStopMusic()
        {
            StopSound(BgAudioSource);
        }
        /// <summary>
        /// 暂停背景音乐
        /// </summary>
        public void BGPauseMusic()
        {
            PauseSound(BgAudioSource);
        }
        /// <summary>
        /// 恢复背景音乐的播放
        /// </summary>
        public void BGResumeMusic()
        {
            ResumeSound(BgAudioSource);
        }

        #endregion
        #region 正常音乐的播放
        /// <summary>
        /// 正常音乐的播放（string = 要播放的音乐名字）
        /// </summary>
        public void PlaySoundNormal(string soundName)
        {
            PlaySound(NormalAudioSource, LoadSound(soundName), 0.7f);
        }
        #endregion
        #region  封装功能
        /// <summary>
        /// 停止音乐的播放（audioSource = 要停止的音乐播放器）
        /// </summary>
        private void StopSound(AudioSource audioSource)
        {
            audioSource.Stop();
        }
        /// <summary>
        /// 暂停的播放（audioSource = 要停止的音乐播放器）
        /// </summary>
        private void PauseSound(AudioSource audioSource)
        {
            audioSource.Pause();
            audioSource.mute = true;
        }
        /// <summary>
        /// 继续音乐的播放（audioSource = 要停止的音乐播放器）
        /// </summary>
        private void ResumeSound(AudioSource audioSource)
        {
            audioSource.UnPause();
            audioSource.mute = false;
        }
        /// <summary>
        /// 播放一个音乐（audioSource = 选择音乐源,audioClip = 要播放的音乐,Volume = 音量大小，loop = 是否循环，默认为false不循环）
        /// </summary>
        private void PlaySound(AudioSource audioSource,AudioClip audioClip,float Volume,bool loop = false)
        {
            audioSource.clip = audioClip;
            audioSource.loop = audioClip;
            audioSource.volume = Volume;
            audioSource.loop = loop;
            audioSource.mute = false;
            audioSource.Play();
            Debug.Log("播放音乐");
        }
         /// <summary>
        /// 在resources内加载一个音乐（string = 音乐的名字）
        /// </summary>
        private AudioClip LoadSound(string sourceName)
        {
            return Resources.Load<AudioClip>("Sounds/" + sourceName);
        }
        #endregion

    }
}