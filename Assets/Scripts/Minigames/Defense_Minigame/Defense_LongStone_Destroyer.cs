using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Minigame
{
    public class Defense_LongStone_Destroyer : MonoBehaviour
    {
        //Variables
        [SerializeField]
        private Collider2D p_LongStoneCol;
        [SerializeField]
        private int p_DestroyCounter = 0;
        [SerializeField]
        private GameObject[] p_LongStonesStates;

        // The Longstone prefab is destroyed after 3 taps
        private void OnMouseDown()
        {
            if (p_LongStoneCol.gameObject)
            {
                p_DestroyCounter++;
                if (p_DestroyCounter >= 3)
                {
                    Destroy(p_LongStoneCol.gameObject);
                    p_DestroyCounter = 0;
                }

                foreach (var Stones in p_LongStonesStates)
                {
                    for (int i = 0; i < p_LongStonesStates.Length; i++)
                    {
                        int stateIndex = p_DestroyCounter;

                        if (stateIndex == p_DestroyCounter)
                        {
                            p_LongStonesStates[stateIndex].SetActive(true);
                        }
                        else
                        {
                            p_LongStonesStates[i].SetActive(false);
                        }
                    }
                }
            }
        }
    }
}

