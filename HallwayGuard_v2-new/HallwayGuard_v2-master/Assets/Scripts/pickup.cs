﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup : MonoBehaviour
{
    public GameObject gc;

    public AudioSource pickupsound;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            pickupsound.Play();
            gc.GetComponent<GameController>().disrupter++;
            Destroy(gameObject);
        }
    }
}
