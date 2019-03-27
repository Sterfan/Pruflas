using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyBackgrounds : MonoBehaviour
{
    void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Backgrounds");

        DontDestroyOnLoad(this.gameObject);
    }
}
