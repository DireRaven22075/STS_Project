using UnityEngine;
using DireRaven22075;
using System.Threading.Tasks;
namespace STS.Manager
{
    public class AudioManager : Singleton<AudioManager>
    {
        private AudioSource bgmSrc;
        private AudioSource seSrc;
        protected override void Awake()
        {
            base.Awake();

            GameObject obj = new GameObject("BGM");
            bgmSrc = obj.AddComponent<AudioSource>();
            obj.transform.SetParent(this.transform);
            bgmSrc.playOnAwake = false;
            bgmSrc.loop = true;

            obj = new GameObject("SE");
            seSrc = obj.AddComponent<AudioSource>();
            obj.transform.SetParent(this.transform);
            seSrc.playOnAwake = false;
            seSrc.loop = false;
        }
        public void PlayBGM()
        {
            if (bgmSrc.isPlaying)
                return;
            bgmSrc.Play();
        }
        public void PlaySE()
        {

        }
    }
}
