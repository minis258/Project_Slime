using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Minigame
{
    public class Minigame_Selector : MonoBehaviour
    {
        [SerializeField]
        private GameObject p_HPMinigame;
        [SerializeField]
        private GameObject p_SPDMinigame;
        [SerializeField]
        private GameObject p_DEFMinigame;
        [SerializeField]
        private GameObject p_ATKMinigame;
        [SerializeField]
        private GameObject p_Start;
        [SerializeField]
        private Button p_PauseButton;
        [SerializeField]
        private Button p_BackButton;
        [SerializeField]
        private Button p_ResumeButton;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        private void SelectHP()
        {
            p_Start.SetActive(false);
            p_HPMinigame.SetActive(true);
        }

        private void SelectSPD()
        {
            p_Start.SetActive(false);
            p_SPDMinigame.SetActive(true);
        }

        private void SelectDEF()
        {
            p_Start.SetActive(false);
            p_DEFMinigame.SetActive(true);
        }

        private void SelectATK()
        {
            p_Start.SetActive(false);
            p_ATKMinigame.SetActive(true);
        }

        private void SelectStart()
        {
            p_HPMinigame.SetActive(false);
            p_SPDMinigame.SetActive(false);
            p_DEFMinigame.SetActive(false);
            p_ATKMinigame.SetActive(false);
            p_Start.SetActive(true);
        }

        private void PauseGame()
        {
            Time.timeScale = 0;
            p_PauseButton.gameObject.SetActive(false);
            p_BackButton.gameObject.SetActive(true);
            p_ResumeButton.gameObject.SetActive(true);
        }

        private void ResumeGame()
        {
            Time.timeScale = 1;
            p_PauseButton.gameObject.SetActive(true);
            p_BackButton.gameObject.SetActive(false);
            p_ResumeButton.gameObject.SetActive(false);
        }
    }
}

