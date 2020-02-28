using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crouch : MonoBehaviour
{
    public GameObject player;
    public GameObject capsule;
    CharacterController characterCollider;
    CapsuleCollider collider;

    public float crouchradius;
    public float crouchheight;

    public bool uncrouch;

    // Start is called before the first frame update
    void Start()
    {
        characterCollider = player.GetComponent<CharacterController>();
        collider = capsule.GetComponent<CapsuleCollider>();
        uncrouch = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (uncrouch)
        {


            if (Input.GetKey(KeyCode.LeftShift))
            {
                // characterCollider.radius = 1f;
                characterCollider.height = crouchradius;
                collider.height = crouchheight;

            }
            else
            {
                //characterCollider.radius = 2.3f;
                characterCollider.height = 3.5f;
                collider.height = 2f;
            }
        }
    }
}
