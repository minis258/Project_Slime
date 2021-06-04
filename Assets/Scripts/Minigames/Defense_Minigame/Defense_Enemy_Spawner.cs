using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Minigame
{
    public class Defense_Enemy_Spawner : MonoBehaviour
    {
        [SerializeField]
        private Transform[] p_Spawners;
        [SerializeField]
        private Transform p_StoneSpawner;
        private int p_SpawnPoints;
        [SerializeField]
        private GameObject p_ShortStonePrefab;
        [SerializeField]
        private GameObject p_LongStonePrefab;
        [SerializeField]
        private GameObject p_VerticalStonePrefab;
        [SerializeField]
        private GameObject p_HorizontalStonePrefab;
        [SerializeField]
        private float p_Spawnrate;
        [SerializeField]
        private float p_Spawntime;
        [SerializeField]
        private float p_StoneSpawnRange;
        [SerializeField]
        private float p_MinSpawnRange;
        [SerializeField]
        private float p_MaxSpawnRange;

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
            SpawnStone();
        }

        private void SetSpawnTimer(float _spawnrate, float _spawntime)
        {
            p_Spawnrate = _spawnrate;
            p_Spawntime = _spawntime;
        }

        private void SpawnStone()
        {
            p_MinSpawnRange = p_StoneSpawner.transform.position.x - p_StoneSpawnRange;
            p_MaxSpawnRange = p_StoneSpawner.transform.position.x + p_StoneSpawnRange;

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
                    GameObject obj = Instantiate(p_ShortStonePrefab, p_Spawners[p_SpawnPoints].position, Quaternion.identity);
                }
            }
        }
    }
}