using System.Collections;
using System.Collections.Generic;
using STS.Manager;
using UnityEngine;
namespace STS.IO
{
    public class BtnField : MonoBehaviour
    {
        public void StartNormalBattle() =>
            GameManager.Instance.StartBattle(Random.Range(0, 100));
        public void StartBossBattle() =>
            GameManager.Instance.StartBattle(Random.Range(10000, 100050));

        public void StartShop() =>
            GameManager.Instance.StartShop(Random.Range(0, 100));

        public void StartEvent() =>
            GameManager.Instance.StartEvent(Random.Range(0, 100));
        
        public void StartRest() =>
            GameManager.Instance.StartRest();
    }
}