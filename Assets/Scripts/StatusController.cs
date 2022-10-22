using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusController : MonoBehaviour
{
    private Anya anyaController;

    //Intervals in seconds.
    public int HUNGER_DECREASING_INTERVAL = 120;
    public int HUNGER_DECREASING_VALUE = 2;

    public int BORING_DECREASING_INTERVAL = 120;
    public int BORING_DECREASING_VALUE = 2;

    public int SLEEP_DECREASING_INTERVAL = 180;
    public int SLEEP_DECREASING_VALUE = 1;

    // Start is called before the first frame update
    void Start()
    {
        anyaController = gameObject.GetComponent<Anya>();
        InvokeRepeating("decreaseHunger", 2.0f, HUNGER_DECREASING_INTERVAL);
    }

    private void decreaseHunger()
    {
        anyaController.setHunger(HUNGER_DECREASING_VALUE*(-1));
        anyaController.getHunger();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
