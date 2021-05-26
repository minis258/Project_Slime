using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Minigame
{
    public class Defense_MouseHandler : MonoBehaviour
    {
        //private bool p_IsDragged = false;
        //[SerializeField]
        //private Collider2D _col;

        //private Vector3 p_DragStartPos;
        //private Vector2 p_DragStartMousePos;
        ////private Vector3 p_RootPos;

        //[SerializeField]
        //private float p_MoveRange;

        //// Start is called before the first frame update
        //void Start()
        //{
        //    //p_RootPos = transform.position;
        //    gameObject.GetComponent<Defense_MouseHandler>();
        //}

        //// Update is called once per frame
        //void Update()
        //{
        //    CheckDragging();
        //}

        //private void OnMouseDown()
        //{
        //    p_IsDragged = true;
        //    p_DragStartMousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //    p_DragStartPos = transform.position;
        //}

        //private void OnMouseUp()
        //{
        //    p_IsDragged = false;
        //}

        //private void CheckDragging()
        //{
        //    if (p_IsDragged)
        //    {
        //        if (_col.gameObject.tag == "Enemy")
        //        {
        //            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        //            //Vector2 mouseDif = mousePos - p_DragStartMousePos;
        //            //mouseDif.y = 0;
        //            //Vector3 newPos = p_DragStartPos + new Vector3(mouseDif.x, mouseDif.y);

        //            //if (newPos.x > p_RootPos.x + p_MoveRange)
        //            //{
        //            //    newPos.x = p_RootPos.x + p_MoveRange;
        //            //}
        //            //else if (newPos.x < p_RootPos.x - p_MoveRange)
        //            //{
        //            //    newPos.x = p_RootPos.x - p_MoveRange;
        //            //}

        //            //transform.position = newPos;
        //            transform.Translate(mousePos);
        //        }
        //        else
        //        {
        //            return;
        //        }
        //    }
        //}

        //######################################################################################
        private float p_StartPosX;
        private float p_StartPosY;
        private bool p_IsDragged = false;

        private void Start()
        {
            this.gameObject.GetComponent<Defense_MouseHandler>();
        }
        private void Update()
        {
            CheckDragging();
        }

        private void OnMouseDown()
        {
            if (Input.GetMouseButton(0))
            {
                Vector2 mousePos = Input.mousePosition;
                mousePos = Camera.main.ScreenToWorldPoint(mousePos);

                p_StartPosX = mousePos.x - this.transform.localPosition.x;
                p_StartPosY = mousePos.y - this.transform.localPosition.y;

                p_IsDragged = true;
            }
        }

        private void OnMouseUp()
        {
            p_IsDragged = false;
        }

        private void CheckDragging()
        {
            if (p_IsDragged == true)
            {
                Vector2 mousePos = Input.mousePosition;
                mousePos = Camera.main.ScreenToWorldPoint(mousePos);

                this.gameObject.transform.localPosition = new Vector2(mousePos.x - p_StartPosX, mousePos.y - p_StartPosY);
            }
        }

        //##########################################################

        //private Vector2 p_MousePos;

        //private float p_DeltaX;
        //private float p_DeltaY;

        //private void Awake()
        //{
        //    this.GetComponent<Defense_MouseHandler>();
        //}

        //private void OnMouseDown()
        //{
        //    p_DeltaX = Camera.main.ScreenToWorldPoint(Input.mousePosition).x - transform.position.x;
        //    p_DeltaY = Camera.main.ScreenToWorldPoint(Input.mousePosition).y - transform.position.y;
        //}

        //private void OnMouseDrag()
        //{
        //    p_MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //    transform.position = new Vector2(p_MousePos.x - p_DeltaX, p_MousePos.y - p_DeltaY);
        //}
    }
}