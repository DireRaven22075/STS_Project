using UnityEngine;
using UnityEngine.SceneManagement;
namespace STS
{
    public class SceneLoadManager : MonoBehaviour
    {
        private static string nextScene = "ERROR";
        public static void LoadScene(string sceneName)
        {
            nextScene = sceneName;
            SceneManager.LoadScene(Constants.Scene.Loading);
        }

        private void Start()
        {
            if (nextScene != "ERROR")
            {
                SceneManager.LoadScene(nextScene, LoadSceneMode.Single);
            }
        }
    }
}