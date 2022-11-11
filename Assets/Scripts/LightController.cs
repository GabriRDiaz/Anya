using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{
    Light lt;
    bool isDarken = false;
    void Start()
    {
        lt = GetComponent<Light>();
        
    }

    public void lightSwitch()
    {
        if (isDarken)
        {
            lt.color = Color.white;
        }
        else
        {
            lt.color = Color.black;
        }
        isDarken = !isDarken;
        Debug.Log(isDarken);
    }

}
