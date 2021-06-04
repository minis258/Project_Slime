using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Minigame
{
    public class Bullet : MonoBehaviour
    {
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
            if (_collision.gameObject.tag == "Enemy")
            {
                Destroy(_collision.gameObject);
                Destroy(gameObject);
            }
        }
    }
}