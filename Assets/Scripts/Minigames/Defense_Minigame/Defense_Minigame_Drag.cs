using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Minigame
{
    public class Defense_Minigame_Drag : MonoBehaviour
    {
        private bool p_IsDragged = false;
        private Collider2D _col;

        [SerializeField]
        private GameObject p_Spawner;
        [SerializeField]
        private float p_MoveRange;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            CheckDragging();
        }

        private void OnMouseDown()
        {
            p_IsDragged = true;
        }

        private void OnMouseUp()
        {
            p_IsDragged = false;
        }

        private void CheckDragging()
        {
            if (p_IsDragged)
            {
                if (_col.gameObject.tag == "Enemy")
                {
                    Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
                    mousePos.z = 0;
                    Vector2 mouseDif = mousePos - p_Spawner.transform.position;
                    Vector3 newPos = p_Spawner.transform.position + new Vector3(mouseDif.x, mouseDif.y);

                    if (newPos.x > p_Spawner.transform.position.x + p_MoveRange)
                    {
                        newPos.x = p_Spawner.transform.position.x + p_MoveRange;
                    }
                    else if (newPos.x < p_Spawner.transform.position.x - p_MoveRange)
                    {
                        newPos.x = p_Spawner.transform.position.x - p_MoveRange;
                    }

                    transform.position = newPos;
                }
                else
                {
                    return;
                }
            }
        }
    }
}

