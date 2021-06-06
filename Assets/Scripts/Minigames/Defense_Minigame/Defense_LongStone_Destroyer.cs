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
            }
        }
    }
}

