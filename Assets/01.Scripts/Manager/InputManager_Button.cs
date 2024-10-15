using DireRaven22075;
using UnityEngine;

namespace STS.Manager
{
    public partial class InputManager : Singleton<InputManager>
    {
        /// <summary>
        /// 필드에서 사건에 진입하기 위한 버튼
        /// </summary>
        public void Button_Battle_Enter()
        {
            //TODO : GameManager 호출 ㅋㅋ
        }
        public void Button_FieldEventEnter()
        {
            //TODO : GameManager 호출 ㅋㅋ
        }
        public void Button_Center()
        {
            //TODO : 필드에서 클릭시 현재 유저 위치로 이동
        }
        public void Button_Quit()
        {
            #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
            #else
            Application.Quit();
            #endif
        }
        public void Button_Pause()
        {
            //TODO : 일시정지
            GameManager.Instance.Pause();
        }
    }
}