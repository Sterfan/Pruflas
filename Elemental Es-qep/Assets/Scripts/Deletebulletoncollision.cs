using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deletebulletoncollision : MonoBehaviour
{
    private void OnTriggerEnter2D()
    {
        Destroy(gameObject);
    }
}
