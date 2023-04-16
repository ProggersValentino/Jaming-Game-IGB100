using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{
    private bool isSafe = false;
    public healthMan stats;
    public float damage;
    public float currentHealth;

    private void Start()
    {
        currentHealth = stats.maxHealth;
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Darkness"))
        {
           TakeDamage(damage);
            
           Debug.Log(currentHealth);
        }
    }
    
    public void TakeDamage(float damage)
    {
        currentHealth -= damage;

        if (currentHealth <= 0)
        {
            currentHealth = 0;
            Debug.Log("dead");
            die();
        }
    }

    public void die()
    {
        Destroy(gameObject);
    }
}
