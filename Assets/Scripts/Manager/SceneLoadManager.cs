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
            else
            {
                Debug.LogError("SceneLoadManager : Scene name is not set");
                SceneManager.LoadScene(Constants.Scene.Main);
            }
        }
    }
}