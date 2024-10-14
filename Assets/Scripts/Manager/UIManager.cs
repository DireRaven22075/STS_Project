using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

using DireRaven22075;
namespace STS
{
    public enum UIType : int
    {
        Pause = 1,
        Setting = 2,
    }
}
namespace STS.Manager
{
    public class UIManager : Singleton<UIManager>
    {

        #region Variable
        private Camera camera;
        [SerializeField]
        private List<Canvas> uiList = new List<Canvas>();
        private Stack<Canvas> stack = new Stack<Canvas>();
        private List<Canvas> stackList = new List<Canvas>();
        #endregion
        protected override void Awake()
        {
            base.Awake();
        }
        protected void Start()
        {
            for (int i = 0; i < transform.childCount; i++)
            {
                uiList.Add(transform.GetChild(i).GetComponent<Canvas>());
            }
        }
        private void Update()
        {
            if (camera == null)
            {
                camera = Camera.main;
            }
            uiList[0].gameObject.SetActive(stack.Count > 0);
        }
        #region Public Methods
        public void Open(UIType type)
        {
            if (stackList.Contains(uiList[(int)type]))
            {
                return;
            }
            if (stack.Count > 0)
            {
                stack.Peek().gameObject.SetActive(false);
            }
            stackList.Add(uiList[(int)type]);
            stack.Push(uiList[(int)type]);
            stack.Peek().gameObject.SetActive(true);
        }
        public void Close()
        {
            if (stack.Count == 0)
            {
                return;
            }
            var temp = stack.Pop();
            stackList.Remove(temp);
            temp.gameObject.SetActive(false);
            if (stack.Count > 0)
            {
                stack.Peek().gameObject.SetActive(true);
            }
        }
        #endregion
    }
}
