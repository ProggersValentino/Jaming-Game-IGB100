using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class collision : MonoBehaviour
{
    private bool isSafe = false;
    public healthMan stats;
    public float darkDmg;
    public float physicalDmg;
    public float currentHealth;
    public float dmgTick;

    private void Start()
    {
        currentHealth = stats.maxHealth;
    }
    

   private void OnTriggerStay(Collider other)
   {
       if (other.CompareTag("Darkness"))
       {
           StartCoroutine(darkOT());
           Debug.Log(currentHealth);
       }
   }


   private void OnCollisionEnter(Collision other)
   {
       if (other.collider.CompareTag("Enemy"))
       {
           TakeDamage(physicalDmg);
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

    IEnumerator darkOT()
    {
        yield return new WaitForSeconds(dmgTick);
        TakeDamage(darkDmg);

        
    }
}
