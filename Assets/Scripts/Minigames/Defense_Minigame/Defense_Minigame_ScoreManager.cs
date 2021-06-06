using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Minigame
{
    public class Defense_Minigame_ScoreManager : MonoBehaviour
    {
        private Vector2 p_StartPos;

       [SerializeField]
        private Text p_ScoreText;

        public float p_CurrentDist;
        public int p_Score;
        // Start is called before the first frame update
        void Start()
        {
            p_StartPos = transform.position;
        }

        // Update is called once per frame
        void Update()
        {
            CalculateScore();
        }

        private void CalculateScore()
        {
            //if (p_StartPos.y > p_CurrentDist)
            //{
            //    p_CurrentDist = this.transform.position.y;
            //}

            //p_Score = Mathf.Round(p_CurrentDist);
            p_CurrentDist = transform.position.y;
            p_Score = (int)p_CurrentDist - (int)p_StartPos.y;
            p_ScoreText.text = "Score: " + p_Score.ToString();
        }
    }
}

