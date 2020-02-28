using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameracrouch : MonoBehaviour
{

    public bool crouch;
    public bool crouchstate;

    // Start is called before the first frame update
    void Start()
    {
        crouch = true;
        crouchstate = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (crouch)
        {
            if ((Input.GetKey(KeyCode.LeftShift)) && !crouchstate)
            {
                transform.position += -Vector3.up * 2;
                crouchstate = true;
            }
            else
            {
                if (!(Input.GetKey(KeyCode.LeftShift)) && crouchstate)
                {
                    transform.position += Vector3.up * 2;
                    crouchstate = false;
                }
            }
        }
    }
}
