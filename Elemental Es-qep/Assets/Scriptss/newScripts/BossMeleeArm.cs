using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMeleeArm : MonoBehaviour
{
    public Transform castPoint;
    private Vector2 dir = new Vector2(0, 1);
    public GameObject Bulletprefab;
    private float range = 8f;
    private float speed = 2;
    private float ShootingDelay = 2f;
    private float cooldownTimer = 2.5f;

    void Start()
    {
        
    }


    void Update()
    {
        cooldownTimer -= Time.deltaTime;

        RaycastHit2D hit = Physics2D.Raycast(castPoint.position, dir, range);
        if (hit == true)
        {
            if (hit.collider.CompareTag("Player") )
            {
                GameObject bullet = (GameObject)Instantiate(Bulletprefab, transform.position, transform.rotation);
                bullet.layer = gameObject.layer;
            }
        }
    }
    
}
