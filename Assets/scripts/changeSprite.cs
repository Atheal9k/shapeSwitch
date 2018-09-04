using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeSprite : MonoBehaviour {

    public string currentTag;
    private SpriteRenderer sr;

    public Sprite triangle;
    public Sprite square;
    public Sprite star;


    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "star" && currentTag == "star")
        {
            
            SetRandomTag();
        }

        if (col.gameObject.tag == "triangle" && currentTag == "triangle")
        {

            SetRandomTag();
        }

        if (col.gameObject.tag == "square" && currentTag == "square")
        {

            SetRandomTag();
        }

        else
        {
            
        }
    }

    void SetRandomTag()
    {
        int index = Random.Range(0,3);

        switch (index)
        {
            case 0:
                currentTag = "star";
                sr.sprite = star;
                break;
            case 1:
                currentTag = "triangle";
                sr.sprite = triangle;
                break;
            case 2:
                currentTag = "square";
                sr.sprite = square;
                break;
            
        }
       
    }
}
