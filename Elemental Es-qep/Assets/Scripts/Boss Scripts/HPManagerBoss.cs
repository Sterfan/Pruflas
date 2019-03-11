﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HPManagerBoss : MonoBehaviour
{
    [SerializeField]
    private int maxHealth = 20;
    public int currentHealth;
    public Slider healthBar;

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
    public void TakingDamage(int damagetaken)
    {
        currentHealth -= damagetaken;
    }
}