using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlSliders : MonoBehaviour
{
    private StatusController status;
    private Anya anyaController;
    public Slider sl;
    // Start is called before the first frame update
    void Start()
    {
        anyaController = GameObject.Find("Anya2D").GetComponent<Anya>();
        switch (sl.name)
        {
            case "SliderHambre":
                sl.value = anyaController.getHunger();
                break;
            case "SliderSueño":
                sl.value = anyaController.getSleepy();
                break;
            case "SliderAburrimiento":
                sl.value = anyaController.getBored();
                break;
        }
        //Debug.Log(sl.value);
    }

    // Update is called once per frame
    void Update()
    {
        switch (sl.name)
        {
            case "SliderHambre":
                sl.value = anyaController.getHunger();
                break;
            case "SliderSueño":
                sl.value = anyaController.getSleepy();
                break;
            case "SliderAburrimiento":
                sl.value = anyaController.getBored();
                break;
        }
    }
}
