using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Minigame
{
    public class Attack_Minigame_ScoreHandler : MonoBehaviour
    {
        public int p_Score;
        [SerializeField]
        private Text p_Text;
        [SerializeField]
        private Text p_EndRoundText;

        public bool EndRound = false;
        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
            CheckScore();
            CheckRound();
        }
        /// <summary>
        /// Set Score text
        /// </summary>
        private void CheckScore()
        {
            p_Text.text = "Score: " + p_Score;
        }

        private void CheckRound()
        {
            if (EndRound == true)
            {
                p_EndRoundText.gameObject.SetActive(true);
                p_EndRoundText.text = "You lost";
                Time.timeScale = 0;
            }
            else
            {
                return;
            }
        }
    }
}

