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
///<summary>
/// 지원 동기 << 나의 가치관을 실현하고 싶은지 고민해봐야할 필요가 있다.
/// 
/// 
/// 
/// 
/// 
/// 
/// 
/// 
/// 
/// 
/// 
/// 
/// 
/// 
/// 
/// 
/// 
/// 
/// 
/// 
/// 
///</summary>