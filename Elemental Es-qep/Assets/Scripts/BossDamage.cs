using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossDamage : MonoBehaviour
{
    
        int health = 20;
        //int damage = 5;

        

        public Slider healthBar;

        private void OnTriggerEnter2D()
        {
        
            Debug.Log(" Enemy is Dead");

            health--;
        }
        void Update()
        {
            healthBar.value = health;

            if (health <= 0)
            {
                Die();
            }
        }
        void Die()
        {
            Destroy(gameObject);
        }
    
}
