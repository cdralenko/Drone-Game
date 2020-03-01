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

    public int musicstate;

    public AudioSource music;

    public AudioClip menumusic;
    public AudioClip gamemusic;
    public AudioClip deathmusic;
    public AudioClip winmusic;

    void Start()
    {
        music.clip = menumusic;
        music.Play();
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
            musicstate = 2;

            failScreen.SetActive(true);
            mainCamera.GetComponent<MouseLook>().MousePlease();

        }

        //music
        if ((musicstate == 0) && (music.clip != menumusic))
        {
            music.Stop();
            music.clip = menumusic;
            music.loop = true;
            music.Play();
        }

        if ((musicstate == 1) && (music.clip != gamemusic))
        {
            music.Stop();
            music.clip = gamemusic;
            music.loop = true;
            music.Play();
        }

        if ((musicstate == 2) && (music.clip != deathmusic))
        {
            music.Stop();
            music.clip = deathmusic;
            music.loop = false;
            music.Play();
        }

        if ((musicstate == 3) && (music.clip != winmusic))
        {
            music.Stop();
            music.clip = winmusic;
            music.loop = false;
            music.Play();
        }

    }
}
