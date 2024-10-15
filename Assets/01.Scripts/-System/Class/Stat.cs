using System.Collections.Generic;
using STS.Interface;
namespace STS.Variable
{
    public class Stat
    {
        #region Variables
        public int HP { get; private set; }
        public int MP { get; private set; }

        private List<IEffect> effects = new List<IEffect>();
        #endregion

        #region Private Methods
        private void ApplyEffect()
        {
            foreach(IEffect element in effects)
            {
                if (element.turn == 0)
                {
                    
                }
                element.Update();
            }
        }
        #endregion

        #region Public Methods
        public void GetTurn()
        {
            
        }
        public void EndTurn()
        {

        }
        public void AddEffect()
        {

        }
        
        public void Damage() {}
        public void Heal() {}



        #endregion
    }
}