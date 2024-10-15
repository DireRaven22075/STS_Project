using STS.Variable;
namespace STS.Interface
{
    /// <summary>
    /// Entity에게 부여하거나, 부여되는 (디)버프의 인터페이스용
    /// turn : Int = 해당 효과의 남은 턴수 (해당 턴수는 턴 종료시 감소)
    /// type : Enum = 해당 효과의 타입 (디버프, 버프, 특수)
    /// owner : IEntity = 해당 버프의 당사자
    /// update : Func<void> = 버프 유저의 턴이 될 때 호출
    /// Apply: Func<Int> = 버프 유저가 행동시 적용
    /// </summary>
    public interface IEffect
    {
        int turn { get; }
        EffectType type { get; }
        IEntity owner { get; }
        void Update();
        void Apply();
    }
}