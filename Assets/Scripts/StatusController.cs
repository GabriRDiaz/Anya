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

    public void addHunger(int value)
    {
        Debug.Log("Error" + value);
        anyaController.setHunger(value);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
