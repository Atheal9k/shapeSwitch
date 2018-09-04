using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomChangeSprite : MonoBehaviour {

    private string currentTag;
    private SpriteRenderer sr;

    public Sprite triangle;
    public Sprite square;
    public Sprite star;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        SetRandomTag();
    }

    void SetRandomTag()
    {
        int index = Random.Range(0, 3);

        switch (index)
        {
            case 0:
                currentTag = "star";
                sr.sprite = star;
                transform.gameObject.tag = "star";
                break;
            case 1:
                currentTag = "triangle";
                sr.sprite = triangle;
                transform.gameObject.tag = "triangle";
                break;
            case 2:
                currentTag = "square";
                sr.sprite = square;
                transform.gameObject.tag = "square";
                break;

        }

    }
}
