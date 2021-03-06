﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomKey : MonoBehaviour
{
    public bool collected = false;
    MeshRenderer rend;
    public LockRoomA room;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Collect();
        }
    }

    public virtual void Collect()
    {
        if(room != null && !collected)
        {
            collected = true;
            rend.enabled = false;
            room.UpdateStatus();
        }

    }

    public virtual void ResetKey()
    {
        collected = false;
        rend.enabled = true;
    }

}
