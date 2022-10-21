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
        if (Input.GetKeyDown("space"))
        {
            setHunger(1000);
            setSleepy(-1000);
            setBored(30);
        }
    }

    public void setHunger(int value)
    {
        int currentHunger = hunger;
        if (isSanitizedStatusVariables(currentHunger, value))
        {
            hunger = 100;
        }
        else
        {
            hunger = hunger + value;
        }
        
    }

    public void setSleepy(int value)
    {
        int currentSleepy = sleepy;
        if (isSanitizedStatusVariables(currentSleepy, value))
        {
            sleepy = 100;
        }
        else
        {
            sleepy = sleepy + value;
        }
        
    }

    public void setBored(int value)
    {
        int currentBored = bored;
        if (isSanitizedStatusVariables(currentBored, value))
        {
            bored = 100;
        }
        else
        {
            bored = bored + value;
        }

    }

    //In case the result lead to an undesirabled value, we set it to 100 and return.
    private bool isSanitizedStatusVariables(int currentValue, int addedValue)
    {
        if (currentValue + addedValue > 100 || currentValue + addedValue < 100 || currentValue > 100 || currentValue < 0)
            return true;
        return false;
    }

}
