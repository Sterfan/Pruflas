
using UnityEngine;

public class Healthpickup : MonoBehaviour
{
    HealthManagerPlayer playerHealth;

    public float healthPickUp = 5f;
    float deleteTime = 1f;

    void Awake()
    {
        playerHealth = FindObjectOfType<HealthManagerPlayer>();

    }


    void OnTriggerEnter2D(Collider2D other)
    {

        FindObjectOfType<AudioManager>().Play("UpgradeHealth");

        if (playerHealth.currentHealth < playerHealth.maxHealth)
        {
            Destroy(gameObject);
            playerHealth.currentHealth = playerHealth.currentHealth + healthPickUp;
        }
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
