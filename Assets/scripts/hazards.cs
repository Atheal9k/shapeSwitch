using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hazards : MonoBehaviour {

    public float speed;
    public changeSprite cs;
   

    void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "player")
        {
            
            Destroy(gameObject);
        }
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
