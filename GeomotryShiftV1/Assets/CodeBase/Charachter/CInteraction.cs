﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CInteraction : MonoBehaviour
{

    GameObject target;

    //Many of these values are redundant and for testing purposes only
    public Collider[] obj;
    public GameObject targetObj;
    public CInteractable targetInteraction;



    public LayerMask mask;
    public float radius = 1f;
    public float maxDistance = 1f;
   
    private Vector3 pos;
    public Vector3 direction;
    public float distance;


    private bool uiSet = false;


    // Start is called before the first frame update
    void Start()
    {
        distance = maxDistance;
    }

    // Update is called once per frame
    void Update()
    {
        //TODO: This code is messy and must be cleaned up and factored


        //RaycastHit hit;
        pos = transform.position;
        //direction = Vector3.zero;

        //if (Physics.SphereCast(pos, radius, direction, out hit, maxDistance, mask))
        //{
        //    Debug.Log("hit");
        //    distance = hit.distance;
        //    if (distance <= 2)
        //    {
        //        Debug.Log("in range");
        //    }

        //}
        
        //TODO: Remove hard coded key
        //TODO: Create link to user interface
        obj = Physics.OverlapSphere(pos, radius, mask);
        if (obj.Length > 0)
        {
            targetObj = obj[0].gameObject;
            if (Input.GetKeyDown(KeyCode.E))
            {
                targetObj.GetComponent<CInteractable>().Trigger();

            }       
        }
        else
        {
            targetObj = null;
        }
    }

    void Scan()
    {

    }
    void SetUI()
    {

    }
    void UnsetUI()
    {

    }
    //For debug purposes only - remove for finished product
    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(pos + direction * distance, radius);
    }
}
