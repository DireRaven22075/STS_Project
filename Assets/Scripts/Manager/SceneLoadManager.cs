using UnityEngine;
using UnityEngine.SceneManagement;
namespace STS
{
    public class SceneLoadManager : MonoBehaviour
    {
        private static string nextScene = "";
        public static void LoadScene(string sceneName)
        {
            nextScene = sceneName;
            SceneManager.LoadScene(Constants.Scene.Loading);
        }

        private void Start()
        {
            if (nextScene == "")
            {
                SceneManager.LoadScene(Constants.Scene.Main);
                return;
            }
            SceneManager.LoadScene(nextScene, LoadSceneMode.Single);
        }
    }
}