using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Minigame
{
    public class Spd_Minigame : MonoBehaviour
    {
        [SerializeField]
        private SpdM_Movement p_Move;
        [SerializeField]
        private Text p_ScoreText;

        public float p_MinHeight;
        // Start is called before the first frame update
        void Start()
        {
            //GameObject.FindGameObjectWithTag("Player");
        }

        // Update is called once per frame
        void Update()
        {
            CalculateScore();
        }

        private void CalculateScore()
        {
            if (p_Move.p_Rigid.velocity.y > 0 && p_Move.p_Rigid.transform.position.y > p_MinHeight)
            {
                p_MinHeight = p_Move.p_Rigid.transform.position.y;
            }

            p_ScoreText.text = "Distance: " + Mathf.Round(p_MinHeight).ToString();
        }
    }
}

