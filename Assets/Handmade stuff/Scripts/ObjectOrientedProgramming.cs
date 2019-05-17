using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectOrientedProgramming : MonoBehaviour
{

}

public class Fruit
{
    public string Color;

    public Fruit()
    {
        Color = "red";
    }
    public Fruit(string Color)
    {
        this.Color = Color;
    }

    public void EatMyFruit()
    {
        Debug.Log("You eaten the" + Color + "Fruit");
    }
}

public class Banana : Fruit
{
    public Banana()
    {
        Color = "yellow";
    }

    public void SlipandFall()
    {
        Debug.Log("You didn't see that banana there that the monkey threw,"
            + "You Slip and Fall, and lost 500G.");
    }
}