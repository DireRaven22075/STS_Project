//System Library
using System.Collections;
using System.Collections.Generic;
//UnityEngine Library
using UnityEngine;

//Project Namespace
using STS.Variable;
using STS.Interface;

namespace STS.IO
{
    public class IOKeyboard : MonoBehaviour
    {
        #region Variables

        #endregion
        private void OnEnable()
        {

        }
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                //패 맨 처음 카드를 선택
            }
            if (Input.GetKeyDown(KeyCode.E))
            {
                //패 맨 뒤 카드를 선택
            }
            if (Input.GetKeyDown(KeyCode.W))
            {
                //카드 위치 스왑(?)
            }
            if (Input.GetKey(KeyCode.A))
            {
                //카드 index--
            }
            if (Input.GetKey(KeyCode.D))
            {
                //카드 index++
            }
        }
    }
}