using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileLoop2 : MonoBehaviour
{
    int cupsInTheSink = 4;


    // Start is called before the first frame update
    void Start()
    {
        while(cupsInTheSink > 0)
        {
            Debug.Log("I've washed a cup!");
            cupsInTheSink--;
        }   
    }
}
