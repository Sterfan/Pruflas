using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteBullet : MonoBehaviour
{

    float deleteTime = 1.8f;
    
    void Start()
    {
        
    }

    private void OnTriggerEnter2D()
    {
        Destroy(gameObject);
    }

    void Update()
    {
        deleteTime -= Time.deltaTime;
        
        if (deleteTime <= 0)
        {
            Destroy(gameObject);
        }

    }
}
