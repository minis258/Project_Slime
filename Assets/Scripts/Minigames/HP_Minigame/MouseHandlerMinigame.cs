using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Minigame
{
    public class MouseHandlerMinigame : MonoBehaviour
    {
        //Variables
        private bool p_IsDragged = false;
        [SerializeField]
        private Collider2D _col;

        private Vector3 p_DragStartPos;
        private Vector2 p_DragStartMousePos;
        private Vector3 p_RootPos;

        [SerializeField]
        private float p_MoveRange;

        // Start is called before the first frame update
        void Start()
        {
            p_RootPos = transform.position;
        }

        // Update is called once per frame
        void Update()
        {
            CheckDragging();
        }

        private void OnMouseDown()
        {
            p_IsDragged = true;
            p_DragStartMousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            p_DragStartPos = transform.position;
        }

        private void OnMouseUp()
        {
            p_IsDragged = false;
        }

        /// <summary>
        /// Drag the player with the limit of max range on how far the player can be dragged
        /// </summary>
        private void CheckDragging()
        {
            if (p_IsDragged)
            {
                if (_col.gameObject.tag == "Player")
                {
                    Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                    Vector2 mouseDif = mousePos - p_DragStartMousePos;
                    mouseDif.y = 0;
                    Vector3 newPos = p_DragStartPos + new Vector3(mouseDif.x, mouseDif.y);

                    if (newPos.x > p_RootPos.x + p_MoveRange)
                    {
                        newPos.x = p_RootPos.x + p_MoveRange;
                    }
                    else if (newPos.x < p_RootPos.x - p_MoveRange)
                    {
                        newPos.x = p_RootPos.x - p_MoveRange;
                    }

                    transform.position = newPos;
                }
                else
                {
                    return;
                }
            }
        }

        /// <summary>
        /// Gizmos drawing for showing drag max range
        /// </summary>
        private void OnDrawGizmosSelected()
        {
            Gizmos.color = Color.cyan;
            Vector3 rootPos = Vector3.zero;

            if (Application.isPlaying)
            {
                rootPos = p_RootPos;
            }
            else
            {
                rootPos = transform.position;
            }

            Gizmos.DrawLine(rootPos - Vector3.right * p_MoveRange, rootPos + Vector3.right * p_MoveRange);
        }
    }
}
