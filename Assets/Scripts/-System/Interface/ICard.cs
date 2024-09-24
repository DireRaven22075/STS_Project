using UnityEngine;
using STS.Variable;
using STS.Interface;

namespace STS.Interface
{
    /// <summary>
    /// 카드 스크립트가 상속 받아야 하는 인터페이스
    /// </summary>
    public interface ICard
    {
        string name { get; }
        string description { get; }
        Sprite img { get; }

        int cost { get; }
        int value { get; }
    }
}