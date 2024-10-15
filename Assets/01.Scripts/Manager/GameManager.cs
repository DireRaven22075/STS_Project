using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

using DireRaven22075;

namespace STS.Manager
{
    public class GameManager : Singleton<GameManager>
    {
        public GameState state { get; private set; } = GameState.None;


        public void StartBattle(int id)
        {
            state = GameState.Battle;
            SceneLoadManager.LoadScene(Constants.Scene.Battle);
            //FieldManager.Instance.Save();

        }
        public void StartShop(int id)
        {
            state = GameState.Stage;
            SceneLoadManager.LoadScene(Constants.Scene.Shop);
        }
        public void StartEvent(int id)
        {
            state = GameState.Stage;
            SceneLoadManager.LoadScene(Constants.Scene.Event);
        }
        public void StartRest()
        {
            state = GameState.Stage;
            SceneLoadManager.LoadScene(Constants.Scene.Rest);
        }
        public void Pause()
        {
            state = GameState.Pause;
            Time.timeScale = 0;
            SceneManager.LoadScene("Pause", LoadSceneMode.Additive);
        }
        public void Resume()
        {
            state = GameState.Play;
            Time.timeScale = 1;
            SceneManager.UnloadSceneAsync("Pause");
        }
    }
}