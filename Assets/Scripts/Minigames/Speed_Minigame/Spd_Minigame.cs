using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Minigame
{
    public class Spd_Minigame : MonoBehaviour
    {
        //Variables
        [SerializeField]
        private SpdM_Movement p_Move;
        [SerializeField]
        private Text p_ScoreText;
        [SerializeField]
        private GameObject p_Player;

        public float p_MinHeight;
        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
            CalculateScore();
        }
        ///Count the distance between startpos and current pos as score
        private void CalculateScore()
        {
            if (p_Move.p_Rigid.velocity.y > 0 && p_Move.p_Rigid.transform.position.y > p_MinHeight) // if the velocity of the player is higher than zero  then calculate
            {
                p_MinHeight = p_Move.p_Rigid.transform.position.y;
            }
            p_ScoreText.text = "Distance: " + Mathf.Round(p_MinHeight).ToString(); // mathf.round to round decimal numbers
        }
    }
}

