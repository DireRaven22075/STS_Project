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