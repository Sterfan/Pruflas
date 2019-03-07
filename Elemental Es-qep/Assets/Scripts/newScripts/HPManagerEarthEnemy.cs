using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPManagerEarthEnemy : MonoBehaviour
{
    public int maxHealth = 15;
    public int currentHealth;
    public Slider healthBar;
    public GameObject deathAnimation;
    public int  dropRate = 0;
    public GameObject HPdrop;
    public GameObject earthRam;
    void Start()
    {
        currentHealth = maxHealth;
    }


    void Update()
    {
        healthBar.value = currentHealth;

        if (currentHealth <= 0)
        {
            Instantiate(deathAnimation, transform.position, transform.rotation);

            FindObjectOfType<AudioManager>().Play("PlayerExplosion");

            Destroy(gameObject);

            if (Random.Range(0, 5) == dropRate)
            {
                GameObject pickupdrop = Instantiate(HPdrop, gameObject.transform.position, Quaternion.identity);
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Firebullet")
        {
            currentHealth--;
            FindObjectOfType<AudioManager>().Play("EarthHitWithFire");
        }
        else
        {
            //currentHealth--;
            FindObjectOfType<AudioManager>().Play("WrongHit");
        }


        if (other.gameObject.tag == "Player")
        {
            Instantiate(earthRam, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }

    public void TakingDamage(int damagetaken)
    {
        currentHealth -= damagetaken;
    }
}
