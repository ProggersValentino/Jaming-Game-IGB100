using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{
    private bool isSafe = false;
    public healthMan stats;
    public float damage;

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Darkness"))
        {
           stats.TakeDamage(damage);
            
           Debug.Log(stats.currentHealth);
        }
    }
}
