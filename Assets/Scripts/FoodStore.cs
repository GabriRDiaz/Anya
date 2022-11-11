using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodStore : MonoBehaviour
{
    public GameObject myPrefab;
    public static GameObject[] myObjects;
    // Start is called before the first frame update
    void Start()
    {
        myObjects = Resources.LoadAll<GameObject>("Prefabs");
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.childCount == 0)
        {
            int whichItem = Random.Range(0, 4);
            GameObject myObj = Instantiate(myObjects[whichItem]) as GameObject;
            myObj.transform.position = transform.position;
            myObj.transform.parent = transform;
        }
    }
}
