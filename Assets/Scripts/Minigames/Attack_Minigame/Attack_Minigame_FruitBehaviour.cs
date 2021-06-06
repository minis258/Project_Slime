using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Minigame
{
    public class Attack_Minigame_FruitBehaviour : MonoBehaviour
    {
        [SerializeField]
        private Rigidbody2D p_Rigid;
        [SerializeField]
        private Collider2D p_FruitCol;
        [SerializeField]
        private float p_ForceAtSpawn;

        private Attack_Minigame_ScoreHandler p_ScoreHandler;

        private bool p_IsShot = false;

        private Camera p_Camera;
        // Start is called before the first frame update
        void Start()
        {
            p_Camera = FindObjectOfType<Camera>();
            p_Rigid = GetComponent<Rigidbody2D>();
            p_ScoreHandler = FindObjectOfType<Attack_Minigame_ScoreHandler>();
            p_Rigid.AddForce(transform.up * p_ForceAtSpawn, ForceMode2D.Impulse);
        }

        // Update is called once per frame
        void Update()
        {
            CheckShot();
        }

        private void OnMouseDown()
        {
            p_IsShot = true;
        }

        private void OnMouseUp()
        {
            p_IsShot = false;
        }

        private void CheckShot()
        {
            if (p_IsShot)
            {
                if (p_FruitCol.gameObject.tag == "Enemy")
                {
                    Vector3 mousePos = p_Camera.ScreenToWorldPoint(Input.mousePosition);
                    p_ScoreHandler.p_Score++;
                    Destroy(p_FruitCol.gameObject);
                }
                else
                {
                    return;
                }
            }
        }

        public void SetAttackScoreHandler(Attack_Minigame_ScoreHandler _scoreHandler)
        {
            p_ScoreHandler = _scoreHandler;
        }
    }
}

