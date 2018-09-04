using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapMove : MonoBehaviour
{

    Touch touch;
    private Vector2 targetPos;
    public float Xincrement;

    void Update()
    {
        
            if (Input.touchCount > 0)
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
        

           


    }
}
