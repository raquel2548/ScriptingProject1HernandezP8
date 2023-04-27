using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomeClassGen : MonoBehaviour
{
    //Here is a generic method, Notice the generic
    //type 'T'. This 'T' will replaced at runtime
    //with an actuall value.

    public T GenericMethod<T>(T param)
    {
        return param;
    }
}
