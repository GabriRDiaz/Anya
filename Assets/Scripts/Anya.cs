using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anya : MonoBehaviour
{
    //Values from 100 to 0 where 0 is hungry, sleepy, bored. Stored in JSON
    public int hunger;
    public int sleepy;
    public int bored;

    public bool isEating;
    //Will be on true while sleeping. Stored in JSON.
    public bool isSleeping;

    // Start is called before the first frame update
    void Start()
    {
        setHunger(50);
        setSleepy(50);
        setBored(50);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void setHunger(int value)
    {
        this.hunger = value;
    }

    public void setSleepy(int value)
    {
        this.sleepy = value;
    }

    public void setBored(int value)
    {
        this.bored = value;
    }

}
