using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Minigame
{
    public class SpdM_Movement : MonoBehaviour
    {
        public Rigidbody2D p_Rigid;
        private float p_PlayerInput;
        [SerializeField]
        private float p_MoveSpeed;
        // Start is called before the first frame update
        void Start()
        {
            p_Rigid = GetComponent<Rigidbody2D>();
        }

        // Update is called once per frame
        void Update()
        {
            CheckMovement();
        }

        private void CheckMovement()
        {
            p_PlayerInput = Input.GetAxis("Horizontal");
            p_Rigid.velocity = new Vector2(p_PlayerInput * p_MoveSpeed, p_Rigid.velocity.y);
        }
    }
}

