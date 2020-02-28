using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public GameObject mainCamera;

    private void Start()
    {
        // weird menu script that brings up a harmless error in the console
        SceneManager.UnloadSceneAsync("ConnorScene");
        SceneManager.LoadScene("MainMenu");
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("ConnorScene");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
