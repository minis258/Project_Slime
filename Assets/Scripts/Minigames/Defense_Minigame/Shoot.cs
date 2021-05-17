using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Minigame
{
    public class Shoot : MonoBehaviour
    {
        [SerializeField]
        private Transform p_ShootPos;
        [SerializeField]
        private GameObject p_BulletPrefab;
        [SerializeField]
        private float p_Force;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetButtonDown("Fire1"))
            {
                ShootBullet();
            }
            
        }

        private void ShootBullet()
        {
            GameObject bullet = Instantiate(p_BulletPrefab, p_ShootPos.position, p_ShootPos.rotation);
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            rb.AddForce(p_ShootPos.up * p_Force, ForceMode2D.Impulse);
        }
    }
}