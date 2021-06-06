using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Minigame
{
    public class Player : MonoBehaviour
    {
        [SerializeField]
        private float p_MoveSpeed;

        private bool p_IsActive = false;

        private void Start()
        {
            p_IsActive = true;
        }

        private void Update()
        {
            CheckMovement();
        }

        /// <summary>
        /// Only push the player up on y axis
        /// </summary>
        private void CheckMovement()
        {
            if (p_IsActive)
            {
                transform.position = new Vector2(transform.position.x, transform.position.y + p_MoveSpeed * Time.deltaTime);
            }
        }
    }
}