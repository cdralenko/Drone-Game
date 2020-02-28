using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Elevator : MonoBehaviour
{

    public Transform subject;
    public Transform end;

    public float speed;

    public GameObject mainCamera;
    public GameObject winScreen;

    public bool rise;

    void Start()
    {
        rise = false;
    }

    void Update()
    {
        if (rise)
        {
            float step = speed * Time.deltaTime;
            subject.position = Vector3.MoveTowards(subject.position, end.position, step);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            rise = true;

            winScreen.SetActive(true);
            mainCamera.GetComponent<MouseLook>().MousePlease();
        }
    }
}