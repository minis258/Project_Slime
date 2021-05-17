using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Minigame
{
    public class Enemy : MonoBehaviour
    {
        [SerializeField]
        private float p_MoveSpeed;

        private Transform p_Target;
        // Start is called before the first frame update
        void Start()
        {
            p_Target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        }

        // Update is called once per frame
        void Update()
        {
            ChasePlayer();
        }

        private void ChasePlayer()
        {
            if (Vector2.Distance(transform.position, p_Target.position) > 0)
            {
                transform.position = Vector2.MoveTowards(transform.position, p_Target.position, p_MoveSpeed * Time.deltaTime);
            }
        }
    }
}