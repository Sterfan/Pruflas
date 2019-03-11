using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthManagerPlayer : MonoBehaviour
{

    public float  maxHealth = 20f;
    public float  currentHealth;
    public Slider healthBar;
    public GameObject deathAnimation;
    public Animator animator;


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
            Application.LoadLevel(Application.loadedLevel);
            Instantiate(deathAnimation, transform.position, transform.rotation);

            FindObjectOfType<AudioManager>().Play("PlayerDeath");
        }
    }

    //public void OnFadeComplete()
    //{

    //    animator.SetTrigger("FasdeIn");

    //}

    void OnTriggerEnter2D(Collider2D other)
    {
        
       if (other.gameObject.tag == "HP")
        {
            currentHealth = currentHealth + 5f;
        }

        else if (other.gameObject.tag != "HP")
        {
            Camera.main.GetComponent<ScreenShake>().Shake(0.1f, 0.1f);
            currentHealth--;
        }


       if (other.gameObject.tag == "EarthEnemy")
        {
            Camera.main.GetComponent<ScreenShake>().Shake(0.2f, 0.2f);
            currentHealth -= 5;
        }

    }
    //public void TakingDamage(int damagetaken)
    //{
    //    currentHealth -= damagetaken;
    //}
}
