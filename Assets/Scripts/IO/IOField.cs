using UnityEngine;

namespace STS.IO
{
    public class IOField : MonoBehaviour
    {
        private Transform cam;
        private Transform pos;
        private Vector3 position;
        private void Awake()
        {
            cam = Camera.main.transform;
            if ((pos = GameObject.Find("Field-Pos").transform) != null)
            {
                position = pos.position;
                position.z = -10;
                Debug.LogError("Field-Pos not found");
            }
        }
        private void Update()
        {
            if (Input.GetMouseButton(0))
            {
                Vector3 pos = Input.mousePositionDelta;
                pos.x = 0;
                pos.z = 0;
                cam.transform.position -= pos * 0.3f;
            }
        }

        #region Button Methods
        public void BtnCenter()
        {
            cam.position = position;
        }
        #endregion
    }
}