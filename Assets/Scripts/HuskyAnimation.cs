using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfAnimation : MonoBehaviour
{
    Animator anim;
    void Start()
    {
        anim = this.GetComponent<Animator>();
    }

    void Update()
    {
        // moveLeft
        if (Input.GetKey("w"))
        {
            anim.SetBool("moveLeft", true);
        }
        else
        {
            anim.SetBool("moveLeft", false);
        }

        // jump
        if (Input.GetKey("d"))
        {
            anim.SetBool("jump", true);
        }
        else
        {
            anim.SetBool("jump", false);
        }
    }
}

