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
    /// <summary>
    /// 플레이어의 마우스 입력 처리 스크립트
    /// </summary>
    public class IOMouse : MonoBehaviour
    {
        #region Variables
        private Camera camera = null;
        #endregion
        private void OnEnable()
        {
            camera = camera == null ? Camera.main : camera;
        }
        void Update()
        {
            Vector2 src = camera.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(src, Vector2.zero, Mathf.Infinity, 1 << 6);

            //If there is any gameobjects on mouse position.
            if (hit.collider != null)
            {

            }
        }
    }
}