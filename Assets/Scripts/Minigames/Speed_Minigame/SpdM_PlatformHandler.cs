using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Minigame
{
    public class SpdM_PlatformHandler : MonoBehaviour
    {
        [SerializeField]
        private float p_JumpHeight;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        private void OnCollisionEnter2D(Collision2D _collision)
        {

            if (_collision.gameObject.GetComponent<Rigidbody2D>().velocity.y <= 0)
            {
                _collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * p_JumpHeight);
            }
        }
    }
}

