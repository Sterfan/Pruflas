﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPManagerEarthEnemy : MonoBehaviour
{
    public int maxHealth = 15;
    public int currentHealth;
    public Slider healthBar;
    public GameObject deathAnimation;
    public float dropRate = 0.15f;
    public GameObject HPdrop;
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
            Destroy(gameObject);
            if (Random.Range(0, 1) <= dropRate)
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
        }
        else
        {
            currentHealth--;
        }
    }
    public void TakingDamage(int damagetaken)
    {
        currentHealth -= damagetaken;
    }
}
