using System.Collections.Generic;
using DireRaven22075;
using STS;
using UnityEngine;

namespace STS.Manager
{
    public class FieldManager : MonoBehaviour
    {
        private void Update()
        {
            //Early termination if the game is not in the playing state
            if (GameManager.Instance.state != GameState.Field)
            {
                return;
            }
        }
    }
}
