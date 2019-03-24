using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameAudioWinner : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {

        FindObjectOfType<AudioManager>().Play("Winner");

        //StartCoroutine(Wait());

    }

    //IEnumerator Wait()
    //{

    //    yield return new WaitForSeconds(6.865f);

    //    FindObjectOfType<AudioManager>().Play("TitleTheme2");

    //}

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Y))
        {

            FindObjectOfType<AudioManager>().StopMusic("Winner");

            SceneManager.LoadScene("MenuAdded");

        }

    }
}
