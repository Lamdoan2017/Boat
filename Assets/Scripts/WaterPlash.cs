using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class WaterPlash : MonoBehaviour
{
    public UnityEvent waterPlash;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Ground")
        {
            
            waterPlash?.Invoke();
        }
    }
}
