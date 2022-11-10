using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusController : MonoBehaviour
{
    private Anya anyaController;

    //Intervals in seconds.
    public float HUNGER_DECREASING_INTERVAL = 120f;
    public int HUNGER_DECREASING_VALUE = 2;

    public float BORING_DECREASING_INTERVAL = 120f;
    public int BORING_DECREASING_VALUE = 2;

    public float SLEEP_DECREASING_INTERVAL = 180f;
    public int SLEEP_DECREASING_VALUE = 1;

    public float SLEEP_INCREASING_INTERVAL = 10f;
    public int SLEEP_INCREASING_VALUE = 3;

    private float AUTO_SAVE_INTERVAL = 10f;
    // Start is called before the first frame update
    void Start()
    {
        anyaController = gameObject.GetComponent<Anya>();
        InvokeRepeating("decreaseHunger", 2.0f, HUNGER_DECREASING_INTERVAL);
        InvokeRepeating("decreaseSleep",2.0f, SLEEP_DECREASING_INTERVAL);
        InvokeRepeating("decreaseBoring",2.0f,BORING_DECREASING_INTERVAL);
        InvokeRepeating("autoSaveStatus", 2.0f, AUTO_SAVE_INTERVAL);
    }
    void lightSwitched()
    {
        if (anyaController.isSleeping())
        {
            InvokeRepeating("increaseSleep", 2.0f, SLEEP_INCREASING_INTERVAL);
        }
        else
        {
            CancelInvoke("increaseSleep");
        }
        
    }
    void increaseSleep()
    {
        anyaController.setSleepy(SLEEP_INCREASING_VALUE);
    }
    private void autoSaveStatus()
    {
        StatusData data = new StatusData(
            anyaController.getHunger(),
            anyaController.getSleepy(),
            anyaController.getBored()
        );

        JsonUtils.saveToJson(data);

    }
    private void decreaseHunger()
    {
        anyaController.setHunger(HUNGER_DECREASING_VALUE*(-1));
        anyaController.getHunger();
    }

    public void addHunger(int value)
    {
        if(anyaController.getHunger() > 0){
            anyaController.setHunger(value);
        }
    }
    private void decreaseSleep()
    {
        if(anyaController.getSleepy() > 0){
            anyaController.setSleepy(SLEEP_DECREASING_VALUE*(-1));
        }
    }
    private void decreaseBoring()
    {
        if(anyaController.getBored() > 0) {
            anyaController.setBored(BORING_DECREASING_VALUE*(-1));
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
