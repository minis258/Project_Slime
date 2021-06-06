using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Minigame
{
    public class Defense_Stones_Spawner : MonoBehaviour
    {
        [SerializeField]
        private Transform[] p_LongStoneSpawners;
        [SerializeField]
        private Transform p_StoneSpawner;
        private int p_SpawnPrefabs;
        [SerializeField]
        private GameObject p_ShortStonePrefab;
        [SerializeField]
        private GameObject p_LongStonePrefab;
        [SerializeField]
        private GameObject p_VerticalStonePrefab;
        [SerializeField]
        private GameObject p_HorizontalStonePrefab;
        [SerializeField]
        private GameObject p_StartObject;
        [SerializeField]
        private float p_Spawnrate;
        [SerializeField]
        private float p_Spawntime;
        [SerializeField]
        private float p_StoneSpawnRange;
        private float p_MinSpawnRangeX;
        private float p_MaxSpawnRangeX;
        [SerializeField]
        private float p_MaxSpawnRangeY;
        [SerializeField]
        private float p_STSDist;

        private Vector2 p_NewPos;
        private Vector3 p_TempPos;

        [SerializeField]
        private int p_Vertical_1;
        [SerializeField]
        private int p_Vertical_2;
        [SerializeField]
        private int p_Horizontal_1;
        [SerializeField]
        private int p_Horizontal_2;
        [SerializeField]
        private int p_LongStone;
        [SerializeField]
        private int p_Counter = 0;

        public bool IsActive;
        // Start is called before the first frame update
        void Start()
        {
            IsActive = true;
            SetSpawnTimer(p_Spawnrate, p_Spawntime);
            p_NewPos = p_StartObject.transform.position;
        }

        // Update is called once per frame
        void Update()
        {
            SpawnStone();
            SpawnAllLongStones();
        }

        private void SetSpawnTimer(float _spawnrate, float _spawntime)
        {
            p_Spawnrate = _spawnrate;
            p_Spawntime = _spawntime;
        }

        private void SpawnStone()
        {
            p_MinSpawnRangeX = p_StoneSpawner.transform.position.x - p_StoneSpawnRange;
            p_MaxSpawnRangeX = p_StoneSpawner.transform.position.x + p_StoneSpawnRange;

            Vector3 temp = new Vector3(0,0,0);
            

            if (Time.time > p_Spawntime)
            {
                p_Spawntime = Time.time + p_Spawnrate;

                if (!IsActive)
                {
                    float distY = Vector3.Distance(temp, p_TempPos);
                    if (distY > p_STSDist || distY < p_STSDist)
                    {
                        IsActive = true;
                    }
                    return;
                }

                if (IsActive)
                {
                    temp = transform.position;

                    float rdmPos = Random.Range(p_MinSpawnRangeX, p_MaxSpawnRangeX);
                    Vector3 newPos = new Vector3(rdmPos, 0, 0);
                    GameObject obj = Instantiate(p_ShortStonePrefab, p_StoneSpawner.transform.position + newPos, Quaternion.identity);

                }
            }
        }

        private void SpawnAllLongStones()
        {
            foreach (var stones in p_LongStoneSpawners)
            {
                float dist = Vector3.Distance(p_NewPos, stones.position);
                Vector3 temp;

                if (dist >= p_MaxSpawnRangeY)
                {
                    for (int i = 0; i < p_LongStoneSpawners.Length; i++)
                    {
                        if (i == p_Vertical_1)
                        {
                            temp = transform.position;
                            temp = p_TempPos;
                            IsActive = false;
                            GameObject obj = Instantiate(p_VerticalStonePrefab, p_LongStoneSpawners[p_Vertical_1].transform.position, Quaternion.identity);
                            GameObject obj2 = Instantiate(p_VerticalStonePrefab, p_LongStoneSpawners[p_Vertical_2].transform.position, Quaternion.identity);
                            p_NewPos.y = obj.transform.position.y;
                            p_Counter++;
                        }
                        if (p_Counter == 2)
                        {
                            if (i == p_Horizontal_1)
                            {
                                GameObject obj = Instantiate(p_HorizontalStonePrefab, p_LongStoneSpawners[p_Horizontal_1].transform.position, Quaternion.identity);
                                GameObject obj2 = Instantiate(p_HorizontalStonePrefab, p_LongStoneSpawners[p_Horizontal_2].transform.position, Quaternion.identity);
                                p_NewPos.y = obj.transform.position.y;
                            }
                            if (i == p_LongStone)
                            {
                                GameObject obj = Instantiate(p_LongStonePrefab, p_LongStoneSpawners[p_LongStone].transform.position, Quaternion.identity);
                                p_NewPos.y = obj.transform.position.y;
                            }
                        }
                        if (p_Counter > 2)
                        {
                            p_Counter = 0;
                        }

                    }
                }
            }
        }
    }
}