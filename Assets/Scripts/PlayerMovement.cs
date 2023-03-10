using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardforce;
    public int a, b;

    

    // Update is called once per frame
    void FixedUpdate ()
    {
        rb.AddForce(0, 0, forwardforce* Time.deltaTime);
        int sideforce = Random.Range(a, b);
        if (Input.GetKey("d"))
        {
            rb.AddForce(sideforce* Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sideforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
}

 
