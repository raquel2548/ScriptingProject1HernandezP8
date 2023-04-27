using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarBand : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Humanoid human = new Humanoid();
        Humanoid enemy = new Enemy();
        Humanoid orc = new Orc();

        //Notice hwo each Humanoid variable contains
        //a reference to a different class in the 
        //inheritance heirarchy, yet each of them
        //calls the Humanoid Yell(0 method.
        human.Yell();
        enemy.Yell();
        orc.Yell();

    }
}
