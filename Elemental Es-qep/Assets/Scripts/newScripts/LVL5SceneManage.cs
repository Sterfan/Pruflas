﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LVL5SceneManage : MonoBehaviour
{
    public Animator transision;
    public string sceneName;

    void Start()
    {

    }


    void Update()
    {
        if (scoreScript.scoreValue >= 300)
        {
            StartCoroutine(LoadScene());
        }
    }

    IEnumerator LoadScene()
    {
        transision.SetTrigger("end");

        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(sceneName);
    }
}
