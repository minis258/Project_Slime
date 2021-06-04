using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Minigame {
    public class HP_Minigame : MonoBehaviour
    {
        [SerializeField]
        private Transform[] p_Spawners;
        [SerializeField]
        private GameObject[] p_FruitPrefabs;
        private int p_SpawnPoints;
        private int p_SpawnFruits;
        private int p_Score;
        [SerializeField]
        private int p_WinScore;
        public int PlayerHP;
        [SerializeField]
        private float p_Spawnrate;
        [SerializeField]
        private float p_Spawntime;

        public bool IsActive;
        public bool HasWon;
        public bool IsDead;
        [SerializeField]
        private Text p_HPText;
        [SerializeField]
        private Text p_ScoreText;
        [SerializeField]
        private Text LoseText;
        [SerializeField]
        private Text WinText;
        // Start is called before the first frame update
        void Start()
        {
            IsActive = true;
            HasWon = false;
            IsDead = false;
            //p_Score = 0;
            //PlayerHP = 3;
            SetSpawnTimer(p_Spawnrate, p_Spawntime);

            LoseText.gameObject.SetActive(false);
            WinText.gameObject.SetActive(false);
        }

        // Update is called once per frame
        void Update()
        {
            SpawnFruits();
            SetText();     
        }

        private void SetSpawnTimer(float _spawnrate, float _spawntime)
        {
            p_Spawnrate = _spawnrate;
            p_Spawntime = _spawntime;
        }

        private void SpawnFruits()
        {
            if (Time.time > p_Spawntime)
            {
                p_Spawntime = Time.time + p_Spawnrate;

                if (!IsActive)
                {
                    return;
                }

                if (IsActive)
                {
                    p_SpawnPoints = Random.Range(0, p_Spawners.Length);
                    p_SpawnFruits = Random.Range(0, p_FruitPrefabs.Length);
                    GameObject obj = Instantiate(p_FruitPrefabs[p_SpawnFruits], p_Spawners[p_SpawnPoints].position, Quaternion.identity);
                    obj.GetComponent<HP_MinigameFruitBehaviour>().SetHPMinigame(this);
                }
            }
        }
        private void SetText()
        {
            p_HPText.text = "HP: " + PlayerHP;
            p_ScoreText.text = "Score: " + p_Score;
            WinText.text = "You ate way too much. Stop eating!";
            LoseText.text = "Game Over";
        }

        public void AddScore(int _point)
        {
            p_Score += _point;

            if (p_Score >= p_WinScore)
            {
                HasWon = true;
                WinText.gameObject.SetActive(true);
                PauseGame();
            }
        }

        public void SubtractHP(int _point)
        {
            PlayerHP -= _point;

            if (PlayerHP < 1)
            {
                IsDead = true;
                LoseText.gameObject.SetActive(true);
                PauseGame();
            }
        }

        private void PauseGame()
        {
            Time.timeScale = 0;
        }
    }
}

