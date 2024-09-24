using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace STS.UI
{
    public class UICards : MonoBehaviour
    {
        [SerializeField]
        private List<Transform> cards = new List<Transform>();
        void Start()
        {
            for (var i = 0; i < this.transform.childCount; i++)
            {
                cards.Add(this.transform.GetChild(i));
            }
        }
        void Update()
        {

        }
    }
}
