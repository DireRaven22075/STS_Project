using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using DireRaven22075;
namespace STS.Manager
{
    /// <summary>
    /// 게임 내 모든 사운드를 관리하는 클래스
    /// 
    /// </summary>
    public class AudioManager : Singleton<AudioManager>
    {
        #region Variables
        private const int channel = 10;
        [SerializeField] private AudioMixer mixer;
        private AudioSource bgm;
        private List<AudioSource> sources = new List<AudioSource>();

        #endregion

        protected override void Awake()
        {
            base.Awake();
            for (int i = 0; i < channel; i++)
            {
                GameObject obj = new GameObject("AudioSource" + i);
                obj.transform.SetParent(transform);
                AudioSource src = obj.AddComponent<AudioSource>();
                src.loop = false;
                src.playOnAwake = false;
                sources.Add(src);
            }
        }
        public void PlayBGM()
        {
        }
        public void SEPlay(string src)
        {
            foreach(AudioSource audio in sources)
            {
                if (!audio.isPlaying)
                {
                    //audio.clip =  AssetBundleManager.Get(src);
                    return;
                }
            }
        }
    }
}
