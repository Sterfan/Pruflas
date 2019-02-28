
using UnityEngine;

public class Healthpickup : MonoBehaviour
{
    HealthManagerPlayer playerHealth;

    public float healthPickUp = 5f;

    void Awake()
    {
        playerHealth = FindObjectOfType<HealthManagerPlayer>();

    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (playerHealth.currentHealth < playerHealth.maxHealth)
        {
            Destroy(gameObject);
            playerHealth.currentHealth = playerHealth.currentHealth + healthPickUp;
        }
    }
}
