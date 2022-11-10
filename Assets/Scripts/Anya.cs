using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anya : MonoBehaviour
{
    private StatusData storedStatus;
    public int hunger;
    public int sleepy;
    public int bored;

    public bool isEating;
    //Will be on true while sleeping. Stored in JSON.
    public bool isSleep;

    public bool isSleeping()
    {
        return this.isSleep;
    }
    // Start is called before the first frame update
    void Start()
    {
        if (JsonUtils.isPathCreated())
        {
            storedStatus = JsonUtils.readData();
        }
        else
        {
            JsonUtils.createFirstTimeData();
            storedStatus = JsonUtils.readData();
        }
        hunger = this.storedStatus.hunger;
        sleepy = this.storedStatus.sleepy;
        bored = this.storedStatus.bored;
        isSleep = false;
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
            hunger = 100;
        }
    }
    public int getHunger() 
    { 
        return hunger;
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
    public int getSleepy()
    {
        return sleepy;
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
   public int getBored() {
        return  this.bored;
   }

    //In case the result lead to an undesirabled value, we set it to 100 and return.
    private bool isSanitizedStatusVariables(int currentValue, int addedValue)
    {
        int result = currentValue + addedValue;
        if (result > 100 || currentValue > 100 || currentValue < 0)
            return false;
        return true;
    }

}
