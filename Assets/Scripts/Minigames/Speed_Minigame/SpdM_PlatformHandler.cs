using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Minigame
{
    public class SpdM_PlatformHandler : MonoBehaviour
    {
        [SerializeField]
        private float p_JumpHeight;
        public float p_Timer = 0f;
        public float p_MaxTimer;
        /// <summary>
        /// Add force when the player lands on a platform
        /// </summary>
        /// <param name="_collision"></param>
        private void OnCollisionEnter2D(Collision2D _collision)
        {

            if (_collision.gameObject.GetComponent<Rigidbody2D>().velocity.y <= 0)
            {
                p_Timer = 0f;
                _collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * p_JumpHeight);

                StartTimer();
            }
        }

        private void StartTimer()
        {
            p_Timer++;
        }
    }
}

