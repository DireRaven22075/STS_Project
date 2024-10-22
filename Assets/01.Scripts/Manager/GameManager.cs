using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;

using DireRaven22075;
namespace STS.Manager
{
    public class GameManager : Singleton<GameManager>
    {
        public GameState state { get; private set; } = GameState.None;

        public bool isPause { get; private set; } = false;
        public int seed { get; private set; } = 0;
        public void Move2Field(FieldType type)
        {
            state = (type == FieldType.Shop) ? GameState.Field : GameState.Battle;
            SceneLoadManager.LoadScene(Constants.Scene.Field);
            switch (type)
            {
                case FieldType.MobBattle:
                    seed = Random.Range(Constants.Setting.mobMin, Constants.Setting.mobMax);
                    break;
                case FieldType.BossBattle:
                    seed = Random.Range(Constants.Setting.bossMin, Constants.Setting.bossMax);
                    break;
            }
            return;
        }
        public void Pause()
        {
            isPause = true;
            Time.timeScale = 0;
        }
        public void Resume()
        {
            isPause = false;
            Time.timeScale = 1;
        }
    }
}