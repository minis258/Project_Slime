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
        // Start is called before the first frame update
        void Start()
        {
            p_HpMiniGame = GetComponent<HP_Minigame>();
            p_Rigid = GetComponent<Rigidbody2D>();
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
                        Debug.Log("here");
                    }
                    if (tag == "BadFruit")
                    {
                        if (p_HpMiniGame.PlayerHP <= 0)
                        {
                            Destroy(_col.gameObject);
                        }

                        p_HpMiniGame.SubtractHP(p_Value);
                        Destroy(gameObject);
                    }
                    break;

                case "Enviroment":
                    Destroy(gameObject);
                    break;

            }
        }
    }
}

