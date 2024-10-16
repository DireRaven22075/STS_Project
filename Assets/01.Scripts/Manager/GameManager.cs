using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;

using DireRaven22075;
namespace STS
{
    public enum FieldType : int
    {
        Empty = 0,
        NormalBattle = 1,
        BossBattle = 2,
        Shop = 3

    }
}
namespace STS.Manager
{
    public class GameManager : Singleton<GameManager>
    {
        public GameState state { get; private set; } = GameState.None;

        public void Move2Field(FieldType type)
        {
            switch (type)
            {
                case FieldType.NormalBattle:
                    state = GameState.Field;
                    SceneLoadManager.LoadScene(Constants.Scene.Field);
                    break;
                case FieldType.BossBattle:

                    break;
                case FieldType.Shop:

                    break;
            }
        }
        public void Pause()
        {
            state = GameState.Pause;
            Time.timeScale = 0;
        }
        public void Resume()
        {
            state = GameState.Play;
            Time.timeScale = 1;
        }
    }
}