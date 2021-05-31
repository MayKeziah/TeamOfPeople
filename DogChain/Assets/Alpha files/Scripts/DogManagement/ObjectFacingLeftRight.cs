using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectFacingLeftRight : MonoBehaviour
{
    private Rigidbody2D rb2d;
    private SpriteRenderer spriterend;
    public Sprite leftFacingSprite;
    public Sprite rightFacingSprite;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        spriterend = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void FaceLeft()
    {
        spriterend.sprite = leftFacingSprite;
    }

    public void FaceRight()
    {
        spriterend.sprite = rightFacingSprite;
    }
}
