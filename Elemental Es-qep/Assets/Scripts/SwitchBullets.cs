using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchBullets : MonoBehaviour
{
    public int selectBullet = 0;

    void Start()
    {
        SelectBullet();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            selectBullet = 0;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2) && transform.childCount >= 2)
        {
            selectBullet = 1;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3) && transform.childCount >= 3)
        {
            selectBullet = 2;
        }
        if (Input.GetKeyDown(KeyCode.Alpha4) && transform.childCount >= 4)
        {
            selectBullet = 3;
        }
    }
    void SelectBullet()
    {
        int i = 0;
        foreach(Transform bullet in transform)
        {
            if (i == selectBullet)
                bullet.gameObject.SetActive(true);
            else
                bullet.gameObject.SetActive(false);

            i++;
        }

    }
}
