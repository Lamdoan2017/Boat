using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Continue : MonoBehaviour
{
    public GameObject[] line;
     int index;

    void Start()
    {
        index = 0;
    }

    
    public void Next()
    {
        index += 1;

        for (int i = 0; i < line.Length; i++)
        {
            line[i].gameObject.SetActive(false);
            line[index].gameObject.SetActive(true);
           
         }
        Debug.Log(index);

    }
}

  
