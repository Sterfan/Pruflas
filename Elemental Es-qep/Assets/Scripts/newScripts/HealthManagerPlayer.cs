using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManagerPlayer : MonoBehaviour
{

    public float  maxHealth = 20f;
    public float  currentHealth;
    public Slider healthBar;
    public GameObject deathAnimation;

    void Start()
    {
        currentHealth = maxHealth;
    }


    void Update()
    {
        healthBar.value = currentHealth;

        if (currentHealth <= 0)
        {
            Destroy(gameObject);
            Instantiate(deathAnimation, transform.position, transform.rotation);

            FindObjectOfType<AudioManager>().Play("PlayerExplosion");
            //yield return new WaitForSeconds(5);
            Application.LoadLevel(Application.loadedLevel);
        }
    }
     void OnTriggerEnter2D(Collider2D other)
    {
        
       if (other.gameObject.tag == "HP")
        {
            currentHealth = currentHealth + 5f;
        }

        else if (other.gameObject.tag != "HP")
        { 
           currentHealth--;
        }

    }
    //public void TakingDamage(int damagetaken)
    //{
    //    currentHealth -= damagetaken;
    //}
}
