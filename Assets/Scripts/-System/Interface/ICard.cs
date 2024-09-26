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
        /// <summary>
        /// 카드 명
        /// </summary>
        string name { get; }
        /// <summary>
        /// 카드 설명
        /// </summary>
        string description { get; }
        /// <summary>
        /// 카드 이미지
        /// </summary>
        Sprite img { get; }

        int cost { get; }
        int value { get; }
    }
}