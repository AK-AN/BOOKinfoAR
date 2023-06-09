using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeBehaviour : MonoBehaviour
{
    public void LoadARscene()
    {
        SceneManager.LoadScene("ARBOOK");
    }
    
    public void ExitApp()
    {
        Application.Quit();
        Debug.Log("You have exited the app");
    }

    public void LoadMenuScene()
    {
        SceneManager.LoadScene("Menu_scene");
    }
}
