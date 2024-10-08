using UnityEngine;
using UnityEngine.SceneManagement;
using STS.Manager;


namespace STS.IO
{
    public class IOPause : MonoBehaviour
    {
        private void Awake()
        {

        }
        private void Update()
        {
            
        }

        #region Button Methods
        public void BtnClose()
        {
            SceneManager.UnloadSceneAsync("UI-Pause");
            return;
        }
        public void BtnReturnToTitle()
        {
            SceneManager.UnloadSceneAsync("UI-Pause");
            SceneManager.LoadScene("Title");
            return;
        }
        #endregion
    }
}