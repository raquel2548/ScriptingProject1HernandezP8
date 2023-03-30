using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConversationScript : MonoBehaviour
{
    public int intelligence = 5;

    void Start()
    {
        Greet();  
    }

    void Greet()
    {
        switch (intelligence)
        {
            case 5:
                print("HEllO!!!");
                break;
            case 4:
                print("HOPE");
                break;
            case 3:
                print("YOU");
                break;
            case 2:
                print("HAVE");
                break;
            case 1:
                print("A");
                break;
            default:
                print("GREAT DAY!!");
                break;
        }
    }
}
