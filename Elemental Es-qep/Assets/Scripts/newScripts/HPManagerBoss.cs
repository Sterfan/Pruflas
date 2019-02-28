using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HPManagerBoss : MonoBehaviour
{
    [SerializeField]
    private int maxHealth = 50;
    public int currentHealth;
    public Slider healthBar;

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
        }
    }
    private void OnTriggerEnter2D()
    {
        currentHealth -= 2;
        //if (other.gameObject.tag == "Waterbullet")
        //{
        //    currentHealth--;
        //}
        //else
        //{
        //    currentHealth--;
        //}
    }

    public void TakingDamage(int damagetaken)
    {
        currentHealth -= damagetaken;
    }
}
