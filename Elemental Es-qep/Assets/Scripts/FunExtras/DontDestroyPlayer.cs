using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DontDestroyPlayer : MonoBehaviour
{

    void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Player");

        DontDestroyOnLoad(this.gameObject);
    }

    //void Update()
    //{

    //    if(sceneName == ("Winscreen"))
    //    {

    //        GameObject[] objs = GameObject.FindGameObjectsWithTag("Player");

    //        Destroy(this.gameObject);

    //    }

    //}
}
