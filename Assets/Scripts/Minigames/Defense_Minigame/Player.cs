using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Minigame
{
    public class Player : MonoBehaviour
    {
        [SerializeField]
        private float p_MoveSpeed;
        [SerializeField]
        private Defense_Minigame_ScoreManager p_Manager;
        [SerializeField]
        private GameObject p_Player;

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

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.tag == "Enemy")
            {
                p_Manager.EndRound();
                Destroy(p_Player);
                Time.timeScale = 0;
            }
        }
    }
}