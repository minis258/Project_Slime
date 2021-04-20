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
        public int PlayerHP;
        [SerializeField]
        private float p_Spawnrate;
        [SerializeField]
        private float p_Spawntime;

        public bool p_IsActive = false;

        public Text p_HPText;
        public Text p_ScoreText;
        // Start is called before the first frame update
        void Start()
        {
            p_IsActive = true;
            p_Score = 0;
            PlayerHP = 3;
            SetSpawnTimer(p_Spawnrate, p_Spawntime);
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

                if (!p_IsActive)
                {
                    return;
                }

                if (p_IsActive)
                {
                    p_SpawnPoints = Random.Range(0, p_Spawners.Length);
                    p_SpawnFruits = Random.Range(0, p_FruitPrefabs.Length);
                    Instantiate(p_FruitPrefabs[p_SpawnFruits], p_Spawners[p_SpawnPoints].position, Quaternion.identity);
                }
            }
        }
        private void SetText()
        {
            p_HPText.text = "HP: " + PlayerHP;
            p_ScoreText.text = "Score: " + p_Score;
        }

        public void AddScore(int _point)
        {
            p_Score = p_Score += _point;
        }

        public void SubtractHP(int _point)
        {
            PlayerHP = PlayerHP -= _point;
        }
    }
}

