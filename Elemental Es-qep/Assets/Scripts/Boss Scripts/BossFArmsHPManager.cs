using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossFArmsHPManager : MonoBehaviour
{
    [SerializeField]
    private int maxHealth = 20;
    public int currentHealth;


    void Start()
    {
        currentHealth = maxHealth;
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "WaterBullet")
        {
            currentHealth-= 3;

        }
    }
    void Update()
    { 
        if (currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}
