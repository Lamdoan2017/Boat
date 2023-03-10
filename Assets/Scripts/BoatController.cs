using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatController : MonoBehaviour
{
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("a"))
        {
            anim.SetBool("Left", true);
        }
        else
        {
            anim.SetBool("Left", false);
        }
        if (Input.GetKey("d"))
        {
            anim.SetBool("Right", true);
        }
        else
        {
            anim.SetBool("Right", false);
        }
    }
}
