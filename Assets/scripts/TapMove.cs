using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapMove : MonoBehaviour
{
    public float speed;
    //public GameObject player;

    private Rigidbody2D rb;
    
    Touch touch;
    private Vector2 targetPos;
    public float Xincrement;
    public float leftWidth = -1.8f;
    public float rightWidth = 1.8f;



    void Start()
    {
        //ScreenWidth = Screen.Width;
       
    }

    void Update()
    {
        
         /*   if (Input.touchCount > 0)
            {
            touch = Input.GetTouch(0);

            if (touch.position.x < Screen.width / 2)
                {
                    targetPos = new Vector2(transform.position.x + Xincrement, transform.position.y);
                    transform.position = targetPos;
                }

            }
            else if (touch.position.x > Screen.width / 2)
            {
                targetPos = new Vector2(transform.position.x - Xincrement, transform.position.y);
                transform.position = targetPos;
            }
        */

           


    }

    public void moveLeft()
    {
        if (transform.position.x >= leftWidth)
        {
            targetPos = new Vector2(transform.position.x - Xincrement, transform.position.y);
            transform.position = targetPos;
        }
        
    }

    public void moveRight()
    {
        if (transform.position.x <= rightWidth)
        {
            targetPos = new Vector2(transform.position.x + Xincrement, transform.position.y);
            transform.position = targetPos;
        }
        
    }
}
