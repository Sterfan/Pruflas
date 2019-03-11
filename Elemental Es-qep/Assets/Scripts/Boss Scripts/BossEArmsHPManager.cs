using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossEArmsHPManager : MonoBehaviour
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
        if (other.gameObject.tag == "Firebullet")
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
