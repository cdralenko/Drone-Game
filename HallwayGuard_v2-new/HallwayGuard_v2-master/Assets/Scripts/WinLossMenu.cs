using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinLossMenu : MonoBehaviour
{
    public AudioSource buttonsound;

    public void GoMenu()
    {
        buttonsound.Play();
        SceneManager.GetActiveScene();
        SceneManager.LoadScene("ConnorScene");
    }

    public void MenuQuit()
    {
        buttonsound.Play();
        Application.Quit();
    }
}
