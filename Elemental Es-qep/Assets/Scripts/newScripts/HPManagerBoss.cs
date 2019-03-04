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


    
    private void OnTriggerEnter2D()
    {
        currentHealth--;
        //if (other.gameObject.tag == "Waterbullet")
        //{
        //    currentHealth--;
        //}
        //else
        //{
        //    currentHealth--;
        //}
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
