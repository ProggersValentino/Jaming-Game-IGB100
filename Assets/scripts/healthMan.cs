using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[CreateAssetMenu(fileName = "stats", menuName = "ScriptableObjects/Stats")]
public class healthMan : ScriptableObject
{
    public float currentHealth = 100;
    public float maxHealth;

    private void Awake()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(float damage)
    {
        currentHealth -= damage;

        if (currentHealth <= 0)
        {
            currentHealth = 0;
            die();
        }
    }

    public void die()
    {
        Destroy(this.GameObject());
    }


}
