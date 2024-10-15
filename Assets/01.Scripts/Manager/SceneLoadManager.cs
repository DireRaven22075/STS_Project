using UnityEngine;
using UnityEngine.SceneManagement;
namespace STS
{
    public class SceneLoadManager : MonoBehaviour
    {
        private static string nextScene = null;
        public static void LoadScene(string sceneName)
        {
            nextScene = sceneName;
            SceneManager.LoadScene(Constants.Scene.Loading);
        }

        private void Start()
        {
            if (nextScene == null)
            {
                SceneManager.LoadScene(Constants.Scene.Error);
                return;
            }
            SceneManager.LoadScene(nextScene, LoadSceneMode.Single);
        }
    }
}