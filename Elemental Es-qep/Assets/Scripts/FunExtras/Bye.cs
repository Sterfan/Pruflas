using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bye : MonoBehaviour
{
    Vector2 offset;
    
    public float yVelocity = 0.09f;

    private void Awake()
    {
        
    }

    void Start()
    {
        offset = new Vector2(0, yVelocity);
    }

    void Update()
    {
         
    }
}
