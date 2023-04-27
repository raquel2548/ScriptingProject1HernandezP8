using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMemberHid : MonoBehaviour
{
    //This hides the Humanoid version
    new public void Yell()
    {
        Debug.Log("Enemy version of the Yelll() method");
    }
}
