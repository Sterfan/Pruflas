using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundaries : MonoBehaviour
{
    private Vector2 screenboundary;
    private float playerWidth;
    private float playerHeight;
    

    void Start()
    {
        playerWidth = transform.localScale.x / -0.19f;
        playerHeight = transform.localScale.y / -0.19f;
        screenboundary = new Vector2(Camera.main.aspect * Camera.main.orthographicSize + playerWidth, Camera.main.orthographicSize + playerHeight);
    }

    
    void Update()
    {
        if (transform.position.x < -screenboundary.x)
        {
            transform.position = new Vector2(-screenboundary.x, transform.position.y);
        }
        else if (transform.position.x > screenboundary.x)
        {
            transform.position = new Vector2(screenboundary.x, transform.position.y);
        }

        if (transform.position.y < -screenboundary.y)
        {
            transform.position = new Vector2(transform.position.x, - screenboundary.y);
        }
        else if (transform.position.y > screenboundary.y)
        {
            transform.position = new Vector2(transform.position.x, screenboundary.y);
        }
    }
}
