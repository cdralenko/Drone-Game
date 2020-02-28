using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class REEEEEEE : MonoBehaviour
{
    public GameObject mainCamera;

    private void Start()
    {
        mainCamera.GetComponent<MouseLook>().enabled = false;
        mainCamera.GetComponent<MouseLook>().MousePlease();
    }

    public void PlayGame()
    {
        mainCamera.GetComponent<MouseLook>().enabled = true;
        mainCamera.GetComponent<MouseLook>().GoAwayMouse();
        Destroy(GameObject.FindWithTag("Menu"));
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
