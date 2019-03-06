using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private bool buttonSelected;
    public EventSystem eventSystem;
    public GameObject selectedObject;

    private void Update()
    {
        if (Input.GetAxisRaw("Vertical") != 0 && buttonSelected == false)
        {
            eventSystem.SetSelectedGameObject(selectedObject);
            buttonSelected = true;
        }
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("Maher's scene"); 
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();

    }
}
