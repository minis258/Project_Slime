using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Minigame
{
    public class Defense_MouseHandler : MonoBehaviour
    {
        private bool p_IsDragged = false;
        [SerializeField]
        private Collider2D p_ShortStoneCol;
        private Camera p_Camera;

        private Vector3 p_DragStartPos;
        [SerializeField]
        private float p_MoveRange;
        [SerializeField]
        private float p_MaxRangeX;

        // Start is called before the first frame update
        void Start()
        {
            //p_RootPos = transform.position;
            p_Camera = FindObjectOfType<Camera>();
            //gameObject.GetComponent<Defense_MouseHandler>();
        }

        // Update is called once per frame
        void Update()
        {
            CheckDragging();
        }

        private void OnMouseDown()
        {
            p_IsDragged = true;
            p_DragStartPos = transform.position;
        }

        private void OnMouseUp()
        {
            p_IsDragged = false;
        }

        private void CheckDragging()
        {
            if (p_IsDragged)
            {
                if (p_ShortStoneCol.gameObject.tag == "Enemy")
                {
                    Vector3 mousePos = p_Camera.ScreenToWorldPoint(Input.mousePosition);
                    mousePos.z = 0;
                    Vector3 mouseDif = mousePos - p_DragStartPos;
                    mouseDif.z = 0;
                    Vector3 newPos = p_DragStartPos + new Vector3(mouseDif.x, mouseDif.y);

                    if (newPos.x > p_DragStartPos.x + p_MoveRange)
                    {
                        newPos.x = p_DragStartPos.x + p_MoveRange;

                        if (newPos.x > p_MaxRangeX)
                        {
                            newPos.x = p_MaxRangeX;
                        }
                    }
                    else if (newPos.x < p_DragStartPos.x - p_MoveRange)
                    {
                        newPos.x = p_DragStartPos.x - p_MoveRange;

                        if (newPos.x < -p_MaxRangeX)
                        {
                            newPos.x = -p_MaxRangeX;
                        }
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