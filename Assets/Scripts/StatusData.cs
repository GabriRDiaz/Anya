using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusData
{
    //Values from 100 to 0 where 0 is hungry, sleepy, bored. Stored in JSON
    public int hunger;
    public int sleepy;
    public int bored;

    public StatusData() { }
    public StatusData(int hunger,int sleepy,int bored)
    {
        this.hunger = hunger;
        this.sleepy = sleepy;
        this.bored = bored;
    }
}
