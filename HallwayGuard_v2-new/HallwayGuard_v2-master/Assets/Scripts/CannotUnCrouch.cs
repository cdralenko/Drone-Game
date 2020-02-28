using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannotUnCrouch : MonoBehaviour
{

    public GameObject player;
    public Camera playercam;


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            player.GetComponent<crouch>().uncrouch = false;
            playercam.GetComponent<cameracrouch>().crouch = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            player.GetComponent<crouch>().uncrouch = true;
            playercam.GetComponent<cameracrouch>().crouch = true;
        }
    }
}
