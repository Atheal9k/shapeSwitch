using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour
{
    

    private Vector3 screenPoint;
    private Vector3 offset;


    

    public bool canDrag = true;
    public bool isDragging = false;
    
    Touch touch;


    void OnMouseDown()
    {
        if (canDrag)
        {
            screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);

            offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
           
            isDragging = true;
            
        }

        else if (!canDrag)
        {
           
            offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(screenPoint.x, screenPoint.y, screenPoint.z));
        }






    }

    void OnMouseUp()
    {


    
        isDragging = false;

       

    }

    void OnMouseDrag()
    {

        if (canDrag)
        {
            Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);

            Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;

            transform.position = curPosition;
            //holdmove.canSlow = false;
            Time.timeScale = 1f;



        }


        if (!canDrag)
        {
            //print("cantdrag2");
            Vector3 curScreenPoint = new Vector3(screenPoint.x, screenPoint.y, screenPoint.z);
            // Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;

            //transform.position = curPosition;
        }








    }








}



