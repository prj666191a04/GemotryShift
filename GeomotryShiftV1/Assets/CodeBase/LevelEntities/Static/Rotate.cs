﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
   // Update is called once per frame
    void Update()
    {
        RotateF();
       
    }
    void RotateF()
    {
        transform.Rotate(new Vector3(0, 0, 1) * (Time.deltaTime * 50));
    }

}