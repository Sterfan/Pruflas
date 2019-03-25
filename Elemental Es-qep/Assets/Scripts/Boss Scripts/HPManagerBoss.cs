using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class HPManagerBoss : MonoBehaviour
{
    [SerializeField]
    private float maxHealth = 20;
    public float currentHealth;
    public Slider healthBar;
    public GameObject deathAnimation;
    public float waitForIT = 1;
    public float cooldown = 1;
    public static bool Win;

    void Start()
    {
        currentHealth = maxHealth;
        Win = false;
    }

    void Update()
    {

        if (currentHealth <= 0)
        {
            cooldown -= Time.deltaTime;
            Win = true;

            Instantiate(deathAnimation, transform.position, transform.rotation);

            if (cooldown <= 0)
            {
                Destroy(gameObject);
                cooldown = waitForIT;
                SceneManager.LoadScene("WinScreen");
            }


        }
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "PlayerBullet")
        {
            currentHealth--;

        }

    }

    public void TakingDamage(int damagetaken)
    {
        currentHealth -= damagetaken;
    }
}





