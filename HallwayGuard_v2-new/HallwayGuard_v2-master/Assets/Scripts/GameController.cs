using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public int health;
    public int gamestate;
    public int disrupter;

    public Text healthtext;
    public Text emptext;

    public GameObject failScreen;
    public GameObject mainCamera;

    void Start()
    {
        health = 5;
        disrupter = 0;

        healthtext.text = "";
        emptext.text = "";
    }


    void Awake()
    {
        Application.targetFrameRate = 60;
    }


    void Update()
    {
        healthtext.text = "Health: " + health;
        emptext.text = "Disrupters: " + disrupter;

        if (health == 0)
        {
            failScreen.SetActive(true);
            mainCamera.GetComponent<MouseLook>().MousePlease();
        }
    }
}
