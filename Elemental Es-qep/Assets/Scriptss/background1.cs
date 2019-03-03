﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class background1 : MonoBehaviour
{
    Material material;
    Vector2 offset;

    private float yVelocity = 0.01f;

    private void Awake()
    {
        material = GetComponent<Renderer>().material;
    }

    void Start()
    {
        offset = new Vector2(0, yVelocity);
    }

    void Update()
    {
        material.mainTextureOffset += offset * Time.deltaTime;
    }
}
