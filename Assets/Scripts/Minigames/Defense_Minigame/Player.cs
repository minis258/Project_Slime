using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Minigame
{
    public class Player : MonoBehaviour
    {
        [SerializeField]
        private Rigidbody2D p_Rigid;
        [SerializeField]
        private Camera p_Cam;

        private Vector2 p_MousePos;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            GetMousePos();
        }

        private void FixedUpdate()
        {
            LookAtMouse();
        }

        private void LookAtMouse()
        {
            Vector2 lookDir = p_MousePos - p_Rigid.position;
            float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
            p_Rigid.rotation = angle;
        }

        private void GetMousePos()
        {
            p_MousePos = p_Cam.ScreenToWorldPoint(Input.mousePosition);
        }
    }
}