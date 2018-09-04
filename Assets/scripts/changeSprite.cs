using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeSprite : MonoBehaviour {

    public string currentTag;
    private SpriteRenderer sr;

    public Sprite triangle;
    public Sprite square;
    public Sprite star;
    int lastRandomNumber = 9;
    int newRandomNumber;
    bool mustBeDifferent = true;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        SetRandomTag();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        
        if (col.gameObject.tag == "star" && currentTag == "star")
        {
            
            SetRandomTag();
            mustBeDifferent = true;
        }

        if (col.gameObject.tag == "triangle" && currentTag == "triangle")
        {

            SetRandomTag();
            mustBeDifferent = true;
        }

        if (col.gameObject.tag == "square" && currentTag == "square")
        {

            SetRandomTag();
            mustBeDifferent = true;
        }

        else
        {
            print("gameover");
        }
    }

    void SetRandomTag()
    {
        while (mustBeDifferent == true)
        {
            int index = Random.Range(0, 3);
            if (index != lastRandomNumber)
            {
                switch (index)
                {
                    case 0:
                        currentTag = "star";
                        sr.sprite = star;
                        lastRandomNumber = 0;
                        break;
                    case 1:
                        currentTag = "triangle";
                        sr.sprite = triangle;
                        lastRandomNumber = 1;
                        break;
                    case 2:
                        currentTag = "square";
                        sr.sprite = square;
                        lastRandomNumber = 2;
                        break;

                }

                mustBeDifferent = false;


            }
        }

        

        

        

        
       
    }
}
