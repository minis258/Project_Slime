using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Minigame
{
    public class Shoot : MonoBehaviour
    {
        private bool p_IsShooting = false;

        private Rigidbody2D p_Rigid;

        private Camera p_Camera;
        // Start is called before the first frame update
        void Start()
        {
            p_Rigid = GetComponent<Rigidbody2D>();
            p_Camera = Camera.main;
        }

        // Update is called once per frame
        void Update()
        {

        }

        private void OnMouseDown()
        {
            StartShooting();
        }

        private void StartShooting()
        {
            p_IsShooting = true;
        }
    }
}

