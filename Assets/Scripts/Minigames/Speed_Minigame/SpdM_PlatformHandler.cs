using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Minigame
{
    public class SpdM_PlatformHandler : MonoBehaviour
    {
        [SerializeField]
        private float p_JumpHeight;

        /// <summary>
        /// Add force when the player lands on a platform
        /// </summary>
        /// <param name="_collision"></param>
        private void OnCollisionEnter2D(Collision2D _collision)
        {

            if (_collision.gameObject.GetComponent<Rigidbody2D>().velocity.y <= 0)
            {
                _collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * p_JumpHeight);
            }
        }
    }
}

