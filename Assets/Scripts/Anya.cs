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
        hunger = 50;
        sleepy = 50;
        bored = 50;
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void setHunger(int value)
    {
        int currentValue = hunger;
        if (isSanitizedStatusVariables(currentValue, value))
        {
            hunger = hunger + value;
        }
        else
        {
            Debug.Log("here");
            hunger = 100;
        }
    }
    public void setSleepy(int value)
    {
        int currentValue = sleepy;

        if (isSanitizedStatusVariables(currentValue, value))
        {
            sleepy = sleepy + value;
        }
        else
        {
            sleepy = 100;
        }
    }

    public void setBored(int value)
    {
        int currentValue = bored;

        if (isSanitizedStatusVariables(currentValue, value))
        {
            bored = bored + value;
        }
        else
        {
            bored = 100;
        }
    }

    //In case the result lead to an undesirabled value, we set it to 100 and return.
    private bool isSanitizedStatusVariables(int currentValue, int addedValue)
    {
        int result = currentValue + addedValue;
        if (result > 100 || result < 0 || currentValue > 100 || currentValue < 0)
            return false;
        return true;
    }

    public void getHunger() { Debug.Log(this.hunger); }
}
