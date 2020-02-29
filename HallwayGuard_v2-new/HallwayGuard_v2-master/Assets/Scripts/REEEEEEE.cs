using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class REEEEEEE : MonoBehaviour
{
    public GameObject mainCamera;

    private void Start()
    {
        mainCamera.GetComponent<MouseLook>().MousePlease();
    }

    public void PlayGame()
    {
        mainCamera.GetComponent<MouseLook>().GoAwayMouse();
        GameObject[] menus = GameObject.FindGameObjectsWithTag("Menu");
        foreach (GameObject menu in menus)
            Destroy(menu);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
