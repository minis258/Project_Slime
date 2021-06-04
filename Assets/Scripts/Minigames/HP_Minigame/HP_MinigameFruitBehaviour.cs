using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Minigame
{
    public class HP_MinigameFruitBehaviour : MonoBehaviour
    {
        private HP_Minigame p_HpMiniGame;
        [SerializeField]
        private Rigidbody2D p_Rigid;
        [SerializeField]
        private int p_Value;
        [SerializeField]
        private float p_Rotation;
        [SerializeField]
        private GameObject p_SmashedPrefab;

        private Vector2 p_CurrentPos;
        // Start is called before the first frame update
        void Start()
        {
            p_Rigid = GetComponent<Rigidbody2D>();
        }
        private void Update()
        {
            RotateFruit();
        }

        private void OnTriggerEnter2D(Collider2D _col)
        {
            switch (_col.gameObject.tag)
            {
                case "Player":
                    if (tag == "GoodFruit")
                    {
                        p_HpMiniGame.AddScore(p_Value);
                        Destroy(gameObject);
                    }

                    if (tag == "BadFruit")
                    {
                        p_HpMiniGame.SubtractHP(p_Value);
                        Destroy(gameObject);

                        if (p_HpMiniGame.PlayerHP < 1)
                        {
                            Debug.Log("here");
                            Destroy(_col.gameObject);
                        }
                    }
                    break;

                case "Enviroment":
                    p_CurrentPos = transform.position;
                    Destroy(gameObject);
                    GameObject obj = Instantiate(p_SmashedPrefab, p_CurrentPos, Quaternion.identity);
                    break;

            }
        }

        public void SetHPMinigame(HP_Minigame _minigame)
        {
            p_HpMiniGame = _minigame;
        }

        private void RotateFruit()
        {
            //transform.Rotate(0, 0, Time.deltaTime * p_Rotation, Space.Self);
        }
    }
}

