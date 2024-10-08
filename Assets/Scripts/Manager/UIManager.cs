using System.Collections.Generic;
using UnityEngine.SceneManagement;
using DireRaven22075;
using UnityEngine;

namespace STS.Manager
{
    public class UIManager : Singleton<UIManager>
    {
        public enum UIType
        {
            Blur,
            Pause,
            Reward,
        }
        private Stack<Canvas> stack = new Stack<Canvas>();
        public void Open(string name)
        {
            if (stack.Count == 0)
            {
                SceneManager.LoadSceneAsync("UI-Blur");
            }
            stack.Push(GameObject.Find("UI-" + name).GetComponent<Canvas>());
        }
        public void Close()
        {
            if (stack.Count > 0)
            {
                if (stack.Count == 1)
                {
                    
                    SceneManager.UnloadSceneAsync("UI-Blur");
                }
            }
            return;
        }
        public void CloseAll()
        {
            while (stack.Count > 0)
            {
                Close();
            }
            return;
        }
    }
}
