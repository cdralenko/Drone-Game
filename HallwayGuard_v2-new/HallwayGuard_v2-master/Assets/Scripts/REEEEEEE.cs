using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class REEEEEEE : MonoBehaviour
{
    public GameObject mainCamera;
    public GameObject gc;
    public AudioSource buttonsound;

    private void Start()
    {
        mainCamera.GetComponent<MouseLook>().MousePlease();
    }

    public void PlayGame()
    {
        buttonsound.Play();
        gc.GetComponent<GameController>().musicstate = 1;
        mainCamera.GetComponent<MouseLook>().GoAwayMouse();
        GameObject[] menus = GameObject.FindGameObjectsWithTag("Menu");
        foreach (GameObject menu in menus)
            Destroy(menu);
    }

    public void QuitGame()
    {
        buttonsound.Play();
        Application.Quit();
    }
}
