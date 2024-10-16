using STS.Interface;
using STS.Manager;
using UnityEngine;

namespace STS.IO
{
    public class BtnFieldBattle : MonoBehaviour, IButton
    {
        public bool isOver { get; private set; } = false;
        public int depth { get; private set; } = 10;
        private void Update()
        {
            if (isOver && Input.GetMouseButtonDown(0))
            {
            }
        }
        public void OnMouseExit()
        {
            isOver = false;
        }
        public void OnMouseOver()
        {
            isOver = true;
        }
    }
}