using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomeOtherClassGen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SomeClassGen myClass = new SomeClassGen();

        //In order to use this method you must
        // tell the method what type to replace
        //'T' with.

        myClass.GenericMethod<int>(5);
    }
}
