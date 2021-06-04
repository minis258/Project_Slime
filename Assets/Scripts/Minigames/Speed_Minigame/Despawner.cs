using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Minigame
{
    public class Despawner : MonoBehaviour
    {
        private Spd_Minigame p_SpdMinigame;
        [SerializeField]
        private GameObject p_Player;
        [SerializeField]
        private GameObject[] p_GrasPlatPrefabs;
        [SerializeField]
        private GameObject[] p_CloudPlatPrefabs;
        private GameObject p_CurrentPlat;

        private int p_PrefabsRange;
        [SerializeField]
        private int p_SpawnRange;
        [SerializeField]
        private int p_SpawnHeight;
        private float p_PlatformDistRange;
        [SerializeField]
        private float p_PlatformMinDist;
        [SerializeField]
        private float p_PlatformMaxDist;
        [SerializeField]
        private float p_PlatformChangeDist;

        private Vector2 p_StartPos;

        private void Start()
        {
            p_StartPos.y = p_Player.transform.position.y;
        }

        private void OnTriggerEnter2D(Collider2D _collision)
        {
            float currentDis = p_Player.transform.position.y - p_StartPos.y;

            if (currentDis < p_PlatformChangeDist)
            {
                p_PrefabsRange = Random.Range(0, p_GrasPlatPrefabs.Length);

                p_PlatformDistRange = Random.Range(p_PlatformMinDist, p_PlatformMaxDist);

                p_CurrentPlat = (GameObject)Instantiate(p_GrasPlatPrefabs[p_PrefabsRange], new Vector2(Random.Range(p_SpawnRange * -1, p_SpawnRange), p_Player.transform.position.y + (p_SpawnHeight + p_PlatformDistRange)), Quaternion.identity);

                Destroy(_collision.gameObject);
            }
            if (currentDis > p_PlatformChangeDist)
            {
                p_PrefabsRange = Random.Range(0, p_CloudPlatPrefabs.Length);

                p_PlatformDistRange = Random.Range(p_PlatformMinDist, p_PlatformMaxDist);

                p_CurrentPlat = (GameObject)Instantiate(p_CloudPlatPrefabs[p_PrefabsRange], new Vector2(Random.Range(p_SpawnRange * -1, p_SpawnRange), p_Player.transform.position.y + (p_SpawnHeight + p_PlatformDistRange)), Quaternion.identity);

                Destroy(_collision.gameObject);
            }
            
        }
    }
}
