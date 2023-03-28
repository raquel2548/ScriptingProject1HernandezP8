using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnumScript : MonoBehaviour
{
    enum Direction { North, East, South, West};

    void Start()
    {
        Direction myDirection;

        myDirection = Direction.North;

        Debug.Log("My direction is South");

        Debug.Log("My oppisite direction is North");
    }

    Direction ReverseDirection (Direction dir)
    {
        if (dir == Direction.North)
            dir = Direction.South;
        else if (dir == Direction.South)
            dir = Direction.North;
        else if (dir == Direction.East)
            dir = Direction.West;
        else if (dir == Direction.West)
            dir = Direction.East;

        return dir;
    }
}
