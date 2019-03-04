using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alpha : MonoBehaviour
{
    SpriteRenderer m_spriteRenderer;

    void Start()
    {
        m_spriteRenderer = GetComponent<SpriteRenderer>();
    }
    
    void Update ()
    {
        m_spriteRenderer.color = new Color(1f, 1f, 1f, .8f);

    }



}
