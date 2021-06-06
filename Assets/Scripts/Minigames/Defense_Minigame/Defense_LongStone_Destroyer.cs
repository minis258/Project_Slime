using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Minigame
{
    public class Defense_LongStone_Destroyer : MonoBehaviour
    {
        [SerializeField]
        private Collider2D p_LongStoneCol;
        [SerializeField]
        private int p_DestroyCounter = 0;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

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

