using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Angler : MonoBehaviour
{

    [SerializeField] private Animator jump;
    public UnityEvent anglerSoud;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            jump.SetBool("Jump", true);
            anglerSoud?.Invoke();
        }
    }
}
