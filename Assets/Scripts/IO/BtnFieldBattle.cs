using STS.Interface;

using UnityEngine;

namespace STS.IO
{
    public class BtnFieldBattle : MonoBehaviour, IButton
    {
        public Sprite onHover { get; private set; }
        public Sprite onClick { get; private set; }
        public Sprite onDisabled { get; private set; }

        public void Hover()
        {

        }
        public void Click()
        {
            
        }
    }
}