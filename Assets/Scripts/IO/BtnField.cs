using STS.Manager;
using UnityEngine;
namespace STS.IO
{
    public class BtnField : MonoBehaviour
    {

        public void BattleStart()
        {
            GameManager.Instance.StartBattle(1);
        }
        public void EventEnter()
        {

        }
        public void Pause()
        {

        }
    }
}