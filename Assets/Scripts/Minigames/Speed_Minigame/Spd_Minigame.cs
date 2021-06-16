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
        private SpdM_PlatformHandler p_SPDHandler;
        [SerializeField]
        private Text p_ScoreText;
        [SerializeField]
        private Text p_EndText;
        [SerializeField]
        private Collider2D p_Player;

        private string p_Score;

        public float p_MinHeight;
        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
            CalculateScore();
            Debug.Log(p_SPDHandler.p_Timer);
        }
        ///Count the distance between startpos and current pos as score
        private void CalculateScore()
        {
            if (p_Move.p_Rigid.velocity.y > 0 && p_Move.p_Rigid.transform.position.y > p_MinHeight) // if the velocity of the player is higher than zero  then calculate
            {
                p_MinHeight = p_Move.p_Rigid.transform.position.y;
            }
            p_Score = Mathf.Round(p_MinHeight).ToString();
            p_ScoreText.text = "Distance: " + p_Score; // mathf.round to round decimal numbers
        }

        private void CheckDeath()
        {
            if (p_SPDHandler.p_Timer >= p_SPDHandler.p_MaxTimer)
            {
                Destroy(p_Player);
                p_EndText.gameObject.SetActive(true);
                p_EndText.text = "Your score was: " + p_Score;
                Time.timeScale = 0;
            }
            else
            {
                p_EndText.gameObject.SetActive(false);
            }
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            p_SPDHandler = this.GetComponent<SpdM_PlatformHandler>();
        }
    }
}

