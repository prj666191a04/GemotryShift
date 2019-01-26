﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriMovementA : CMotor
{
    public float speedMultiplier = 6;
    public float jumpForce = 8f;

    // Update is called once per frame
    void Update()
    {
        Vector3 myVector = new Vector3(0, 0, 0);
        myVector.x = h_;
        myVector.y = rBody.velocity.y;
        myVector.z = v_;
        myVector.x *= speedMultiplier;
        myVector.z *= speedMultiplier;
        this.rBody.velocity = myVector;

    }
    protected override void ConfigurePhysics()
    {
        rBody.useGravity = true;
        rBody.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;
      
    }

    void OnEnable()
    {
        //On first enable this object will be null but 
        //we need to be able to run the following code
        //if it is to be enabled multiple times
        if (rBody != null)
        {
            ConfigurePhysics();
        }
        
    }

    void OnDisable()
    {
        rBody.constraints = RigidbodyConstraints.None;
    }



}