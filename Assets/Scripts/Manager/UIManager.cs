using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
namespace STS.Manager
{
    public class UIManager : Singleton<UIManager>
    {
        private Dictionary<string, GameObject> canvas = new Dictionary<string, GameObject>();
        protected override void Awake()
        {
            base.Awake();
            SceneManager.activeSceneChanged += onChange;
            for (var i = 0; i < this.transform.childCount; i++)
            {
                var obj = this.transform.GetChild(i);
                canvas.Add(obj.name.Split(" ")[0], obj.gameObject);
                Debug.Log(string.Format("{0} | {1}", obj.name.Split(" ")[0], obj.gameObject.name));
            }
        }
        UnityEvent onchange()
        {
            return null;
        }
    }
}
