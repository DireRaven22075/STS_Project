using DireRaven22075;
using UnityEngine;

namespace STS.Manager
{
    public partial class InputManager : Singleton<InputManager>
    {
        public void Button_Center()
        {
            //TODO : 필드에서 클릭시 현재 유저 위치로 이동
        }
        public void Button_Quit()
        {

        }
        public void Button_Pause()
        {
            //TODO : 일시정지
            GameManager.Instance.Pause();
        }
    }
}