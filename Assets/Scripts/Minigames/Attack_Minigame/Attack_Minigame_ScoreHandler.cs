using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Minigame
{
    public class Attack_Minigame_ScoreHandler : MonoBehaviour
    {
        //Variables
        private Attack_Minigame_FruitBehaviour p_Fruit;
        public int p_Score;
        [SerializeField]
        private Text p_Text;
        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
            CheckScore();
        }
        /// <summary>
        /// Set Score text
        /// </summary>
        private void CheckScore()
        {
            p_Text.text = "Score: " + p_Score;
        }
    }
}

