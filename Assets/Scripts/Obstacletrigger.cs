using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Obstacletrigger : MonoBehaviour
{
    //public PlayerMovement movement;

    public UnityEvent hitBoat;
   

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            hitBoat?.Invoke();
        }
    }
    

}




