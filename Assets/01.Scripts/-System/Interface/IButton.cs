
using UnityEngine;

namespace STS.Interface
{
    public interface IButton
    {
        bool isOver { get; }
        void OnMouseOver();
        void OnMouseExit();
    }
}