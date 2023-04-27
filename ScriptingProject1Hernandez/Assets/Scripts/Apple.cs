using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : Fruit
{
    //This is the first constructor for the Apple class.
    //iterator calls the parent constructor immediatly, even
    
    public Apple()
    {
        //Notice how Apple has access to the public variable
        //color, which is a part of the parent Fruit class.
        color = "red";
        Debug.Log("Ist Apple Constructor Called");
    }
    //This is the second constructor for the Apple class.
    //It specifies which parent constructor will be called
    //using the "base" keyword.
    public Apple(string newColor) : base(newColor)
    {
        //Notice how this constructor doesn't set the color
        //since the base constructor sets the color that
        // is passes as an argument.
        Debug.Log("2nd Apple Constructor Called");
    }
}
