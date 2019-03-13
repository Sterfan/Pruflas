using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainSceneChanger : MonoBehaviour
{
    public Animator animator;

    public void PlayGame()
    {

        animator.SetTrigger("FadeIn1");

    }

    void Update()
    {
        if(HealthManagerPlayer.playerAlive == false)
        {

            animator.SetTrigger("PlayerDead");

        }
    }

    //HealthManagerPlayer.playerAlive == false
}
