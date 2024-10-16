using UnityEngine;

using STS.Manager;
namespace STS.IO
{
    public class BtnTitle : MonoBehaviour
    {
        public void GameStart()
        {
            SceneLoadManager.LoadScene(Constants.Scene.Map);
        }
        public void OpenSetting()
        {
            UIManager.Instance.Open(UIType.Setting);
        }
        public void GameExit()
        {
            #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
            #else
            Application.Quit();
            #endif
        }
    }
}
