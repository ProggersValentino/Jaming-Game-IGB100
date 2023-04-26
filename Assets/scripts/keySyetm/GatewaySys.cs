using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GatewaySys : MonoBehaviour
{
    public bool k1Found, k2Found, k3Found;
    public Material[] keys;
    public Material Doors;

    private MeshRenderer doorMesh;
    public enum doorState
    {
        locked,
        unlocked
    }

    public doorState currentDoor;

    private void Start()
    {
        resetKCol();
        doorMesh = GetComponent<MeshRenderer>();
    }

    private void Update()
    {
        unlockingDoor();
        doorHandler();
    }

    void doorHandler()
    {
        if (k1Found && k2Found && k3Found)
        {
            currentDoor = doorState.unlocked;
            // doorMesh.materials = Doors;
        }
        else
        {
            currentDoor = doorState.locked;
        }
    }

    public void unlockingDoor()
    {
        if (k1Found)
        {
            Color color = keys[0].color;
            color.a = 1f;
            keys[0].color = color;
            
            // Debug.Log("colour changed");
        }

        if (k2Found)
        {
            Color color = keys[1].color;
            color.a = 1f;
            keys[1].color = color;

        }
        
        if (k3Found)
        {
            Color color = keys[2].color;
            color.a = 1f;
            keys[2].color = color;

        }
    }

    void resetKCol()
    {
        for (int i = 0; i < keys.Length; i++)
        {
            Color alpha = keys[i].color;
            alpha.a = 0.3f;
            keys[i].color = alpha;

            // if (keys[i].color != alpha)
            // {
            //     keys[i].color = alpha;
            // }
        }
    }

    void changeDoorM()
    {
        
    }
    
}
