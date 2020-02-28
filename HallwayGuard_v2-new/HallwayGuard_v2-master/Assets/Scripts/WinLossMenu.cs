using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinLossMenu : MonoBehaviour
{

    public void GoMenu()
    {
        SceneManager.GetActiveScene();
        SceneManager.LoadScene("ConnorScene");
    }

    public void MenuQuit()
    {
        Application.Quit();
    }
}
