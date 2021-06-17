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
        [SerializeField]
        private Camera p_Camera;
        // Start is called before the first frame update
        void Start()
        {
            p_PauseButton.gameObject.SetActive(false);
        }

        // Update is called once per frame
        void Update()
        {

        }

        public void SelectHP()
        {
            p_Camera.gameObject.SetActive(false);
            p_Start.SetActive(false);
            p_HPMinigame.SetActive(true);
            p_PauseButton.gameObject.SetActive(true);
        }

        public void SelectSPD()
        {
            p_Camera.gameObject.SetActive(false);
            p_Start.SetActive(false);
            p_SPDMinigame.SetActive(true);
            p_PauseButton.gameObject.SetActive(true);
        }

        public void SelectDEF()
        {
            p_Camera.gameObject.SetActive(false);
            p_Start.SetActive(false);
            p_DEFMinigame.SetActive(true);
            p_PauseButton.gameObject.SetActive(true);
        }

        public void SelectATK()
        {
            p_Camera.gameObject.SetActive(false);
            p_Start.SetActive(false);
            p_ATKMinigame.SetActive(true);
            p_PauseButton.gameObject.SetActive(true);
        }

        public void SelectStart()
        {
            p_HPMinigame.SetActive(false);
            p_SPDMinigame.SetActive(false);
            p_DEFMinigame.SetActive(false);
            p_ATKMinigame.SetActive(false);
            p_Camera.gameObject.SetActive(true);
            p_Start.SetActive(true);
            p_PauseButton.gameObject.SetActive(false);
            p_BackButton.gameObject.SetActive(false);
            p_ResumeButton.gameObject.SetActive(false);
        }

        public void PauseGame()
        {
            GameObject obj = GameObject.FindGameObjectWithTag("Player");
            this.transform.position = obj.transform.position;
            p_PauseButton.gameObject.SetActive(false);
            p_BackButton.gameObject.SetActive(true);
            p_ResumeButton.gameObject.SetActive(true);
            Time.timeScale = 0;
        }

        public void ResumeGame()
        {
            p_PauseButton.gameObject.SetActive(true);
            p_BackButton.gameObject.SetActive(false);
            p_ResumeButton.gameObject.SetActive(false);
            Time.timeScale = 1;
        }

        public void QuitGame()
        {
            Application.Quit();
        }
    }
}

