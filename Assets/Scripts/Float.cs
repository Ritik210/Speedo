﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof (Rigidbody))]
public class Float : MonoBehaviour
{
    public float waterLevel = 0.0f;
    public float floatTreshold = 2.0f;
    public float waterDensity = 0.125f;
    public float downForce = 4.0f;

    float forceFactor;
    Vector3 floatForce;
    // Start is called before the first frame update
    /*void Start()
    {
        
    }*/

    // Update is called once per frame
    void FixedUpdate()
    {
        forceFactor = 1.0f - ((transform.position.y - waterLevel) / floatTreshold);

        if(forceFactor > 0.0f)
        {
            floatForce = -Physics.gravity * GetComponent<Rigidbody>().mass * (forceFactor - GetComponent<Rigidbody>().velocity.y * waterDensity);
            floatForce += new Vector3(0.0f, -downForce * GetComponent<Rigidbody>().mass, 0.0f);
            GetComponent<Rigidbody>().AddForceAtPosition(floatForce, transform.position);

        }
        
    }
}
