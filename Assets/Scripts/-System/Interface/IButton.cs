
using UnityEngine;

namespace STS.Interface
{
    public interface IButton
    {
        Sprite onHover { get; }
        Sprite onClick { get; }
        Sprite onDisabled { get; }
        void Hover();
        void Click();
    }
}