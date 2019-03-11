using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossShieldHPManager : MonoBehaviour
{
    [SerializeField]
    private int maxHealth = 30;
    public int currentHealth;
    

    void Start()
    {
        currentHealth = maxHealth;
    }



    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "PlayerBullet")
        {
            currentHealth--;

        }

    }
    void Update()
    {

        //healthBar.value = currentHealth;

        if (currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}
