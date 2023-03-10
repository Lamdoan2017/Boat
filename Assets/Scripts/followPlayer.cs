using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    public float rotate;
    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset;
        transform.rotation = Quaternion.Euler(rotate, 0f, 0f);
    }
}
