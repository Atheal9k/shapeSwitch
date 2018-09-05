using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeSprite : MonoBehaviour {

    public string currentTag;
    private SpriteRenderer sr;

    public Sprite triangle;
    public Sprite square;
    public Sprite star;
    int lastRandomNumber = 9;
    public int health = 3;
    bool mustBeDifferent = true;
    public int damage = 1;
    public Text healthDisplay;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        SetRandomTag();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        
       

        if (col.gameObject.tag == "triangle" && currentTag == "triangle")
        {
            mustBeDifferent = true;
            SetRandomTag();
            
        }

        else if (col.gameObject.tag == "square" && currentTag == "square")
        {
            mustBeDifferent = true;
            SetRandomTag();
            
        }

        else if (col.gameObject.tag == "star" && currentTag == "star")
        {
            mustBeDifferent = true;
            SetRandomTag();

        }

        else
        {
            health -= damage;
        }

       
    }


    void Update()
    {
        healthDisplay.text = health.ToString();

        if (health <= 0)
        {
            FindObjectOfType<GameManager>().GameOver();
            Destroy(gameObject);
        }
    }

    public void SetRandomTag()
    {
        while (mustBeDifferent == true)
        {
            int index = Random.Range(0, 3);
            print(index);
            print("LN:" + lastRandomNumber);
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
