﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelPortal : CInteractable
{
    public GameObject levelObject;

    public Transform exitLocation;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public override void Trigger()
    {
        Debug.Log("portal triggered");
    }



}