using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fpsaimer : MonoBehaviour
{
    public GameObject image;
   

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            image.SetActive(true);
            

        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            image.SetActive(false);
           
        }
        
    }
}
