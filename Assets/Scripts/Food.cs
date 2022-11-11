using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Food : MonoBehaviour
{
    private StatusController status;
    Vector3 initialPos;
    Vector3 offset;
    public string destinationTag = "AnyaHead";
    public int foodAmount = 10;

    void Start()
    {
        initialPos = transform.position;
        Debug.Log(initialPos);
        status = GameObject.Find("Anya2D").GetComponent<StatusController>();
    }

    void OnMouseDown()
    {
        offset = transform.position - MouseWorldPosition();
        transform.GetComponent<Collider>().enabled = false;
    }

    void OnMouseDrag()
    {
        transform.position = MouseWorldPosition() + offset;
    }

    void OnMouseUp()
    {
        var rayOrigin = Camera.main.transform.position;
        var rayDirection = MouseWorldPosition() - Camera.main.transform.position;
        RaycastHit hitInfo;
        if (Physics.Raycast(rayOrigin, rayDirection, out hitInfo))
        {
            if (hitInfo.transform.tag == destinationTag)
            {
                Debug.Log("Anya");
                transform.position = hitInfo.transform.position;
                status.addHunger(foodAmount);
                Destroy(gameObject);
            }
            
        }
        else
        {
            Debug.Log("Out: " + initialPos);
            transform.position = initialPos;
        }
        transform.GetComponent<Collider>().enabled = true;
    }

    Vector3 MouseWorldPosition()
    {
        var mouseScreenPos = Input.mousePosition;
        mouseScreenPos.z = Camera.main.WorldToScreenPoint(transform.position).z;
        return Camera.main.ScreenToWorldPoint(mouseScreenPos);
    }
}