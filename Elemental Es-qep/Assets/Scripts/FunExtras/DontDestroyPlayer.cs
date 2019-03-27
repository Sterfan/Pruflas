using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DontDestroyPlayer : MonoBehaviour
{

    void Start()
    {
        string sceneName = currentScene.name;

        Scene currentScene = SceneManager.GetActiveScene();

        GameObject[] objs = GameObject.FindGameObjectsWithTag("Player");

        DontDestroyOnLoad(this.gameObject);

        if (sceneName == ("Winscreen"))
        {

            GameObject[] objs = GameObject.FindGameObjectsWithTag("Player");

            Destroy(this.gameObject);

        }
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
