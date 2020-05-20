using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour {


    public float totalDistance = 0;
    public bool record = true;
    private Vector3 previousLocation;
    void FixedUpdate()
    {
        if (record)
            RecordDistance();
    }
    void RecordDistance()
    {
        totalDistance += Vector3.Distance(transform.position, previousLocation);
        previousLocation = transform.position;
    }

    void ToggleRecord() => record = !record;

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("You made it!");
        Debug.Log("Distance: " + totalDistance);
    }
}

