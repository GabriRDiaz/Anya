using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SleepButton : MonoBehaviour
{
    private bool isPressed;
    private LightController light;
    private StatusController status;
    private Anya anyaController;

    // Start is called before the first frame update
    void Start()
    {
        status = GameObject.Find("Anya2D").GetComponent<StatusController>();
        light = GameObject.Find("Directional Light").GetComponent<LightController>();
        anyaController = GameObject.Find("Anya2D").GetComponent<Anya>();
        isPressed = false;
    }

    public void turnOffandOn()
    {
        if(!isPressed){
            anyaController.isSleep=true; 
            light.lightSwitch();
            status.lightSwitched();
            isPressed = true;
        }
        else
        {
            anyaController.isSleep = false;
            light.lightSwitch();
            status.lightSwitched();
            isPressed = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
