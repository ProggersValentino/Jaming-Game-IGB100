using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{
    private bool isSafe = false;
    /// <summary>
    /// 
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Destroy(gameObject);
            
            Debug.Log("we working");
        }
    }

    // private void OnTriggerExit(Collider other)
    // {
    //     throw new NotImplementedException();
    // }
}
