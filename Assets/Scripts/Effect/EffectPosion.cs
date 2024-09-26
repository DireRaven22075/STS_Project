using STS.Interface;

namespace STS.Variable
{
    public class EffectPosion : IEffect
    {
        public int turn { get; private set; } = 5;
        public EffectType type { get; private set; }
        public IEntity owner { get; private set; } = null;
        public void Update()
        {

        }
        public void Apply()
        {
        }

        public EffectPosion(IEntity owner)
        {

        }
    }
}