using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Utilities 
{
    //A static mehtod can be invoked without an object
    //of a class. Note that staic methods cannot access
    //non-static membber variables.
    public static int Add(int num1, int num2)
    {
        return num1 + num2;
    }
}
