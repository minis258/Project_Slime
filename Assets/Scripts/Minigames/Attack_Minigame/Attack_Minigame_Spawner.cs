using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Minigame
{
    public class Attack_Minigame_Spawner : MonoBehaviour
    {
        [SerializeField]
        private GameObject p_FruitPrefab;
        [SerializeField]
        private Transform[] p_SpawnPoints;
        private int p_SpawnPointsIndex;
        [SerializeField]
        private float p_SpawnDelayMin;
        [SerializeField]
        private float p_SpawnDelayMax;
        [SerializeField]
        private float p_RdmSpawnerRotation;
        // Start is called before the first frame update
        void Start()
        {
            StartCoroutine(SpawnFruits());
        }

        // Update is called once per frame
        void Update()
        {

        }

        IEnumerator SpawnFruits()
        {
            while (true)
            {
                float delay = Random.Range(p_SpawnDelayMin, p_SpawnDelayMax);
                yield return new WaitForSeconds(delay);

                p_SpawnPointsIndex = Random.Range(0, p_SpawnPoints.Length);
                Transform rdmSpawn = p_SpawnPoints[p_SpawnPointsIndex];
                Quaternion defaultPos = rdmSpawn.transform.rotation;
                //float rdmRot = Random.Range(-p_RdmSpawnerRotation, p_RdmSpawnerRotation);
                rdmSpawn.transform.Rotate(0, 0, Random.Range(rdmSpawn.transform.rotation.z - p_RdmSpawnerRotation, rdmSpawn.transform.rotation.z + p_RdmSpawnerRotation));

                GameObject obj = Instantiate(p_FruitPrefab, rdmSpawn.position, rdmSpawn.rotation);

                rdmSpawn.rotation = defaultPos;
                Destroy(obj, 4f);
            }
        }
    }
}

