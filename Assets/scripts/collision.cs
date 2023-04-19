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
    public float dmgTick;

    private void Start()
    {
        currentHealth = stats.maxHealth;
    }

    private void OnParticleCollision(GameObject other)
    {
        if (other.CompareTag("Darkness"))
        {
            StartCoroutine(darkOT());
            
            Debug.Log(currentHealth);
        }
    }

    // private void OnTriggerStay(Collider other)
    // {
    //    
    // }
    
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

    IEnumerator darkOT()
    {
        TakeDamage(damage);

        yield return new WaitForSeconds(dmgTick);
    }
}
