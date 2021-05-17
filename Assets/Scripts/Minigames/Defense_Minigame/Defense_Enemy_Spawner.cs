using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Minigame
{
    public class Defense_Enemy_Spawner : MonoBehaviour
    {
        [SerializeField]
        private Transform[] p_Spawners;
        private int p_SpawnPoints;
        [SerializeField]
        private GameObject p_EnemyPrefab;
        [SerializeField]
        private float p_Spawnrate;
        [SerializeField]
        private float p_Spawntime;

        public bool IsActive;
        // Start is called before the first frame update
        void Start()
        {
            IsActive = true;
            SetSpawnTimer(p_Spawnrate, p_Spawntime);
        }

        // Update is called once per frame
        void Update()
        {
            SpawnEnemy();
        }

        private void SetSpawnTimer(float _spawnrate, float _spawntime)
        {
            p_Spawnrate = _spawnrate;
            p_Spawntime = _spawntime;
        }

        private void SpawnEnemy()
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
                    GameObject obj = Instantiate(p_EnemyPrefab, p_Spawners[p_SpawnPoints].position, Quaternion.identity);
                }
            }
        }
    }
}