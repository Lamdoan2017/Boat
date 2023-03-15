using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;

    public Animator anim;

    public UnityEvent hitBoat;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "obstacle")
        {
            movement.enabled = false;
            anim.SetBool("Sink", true);
            hitBoat?.Invoke();
        }
    }
   
}
