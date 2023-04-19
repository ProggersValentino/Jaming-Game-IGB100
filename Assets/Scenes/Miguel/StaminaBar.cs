using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StaminaBar : MonoBehaviour
{

// Stamina
public Slider staminaBar;
public movement stamina;

//Health
public Slider healthBar;
[SerializeField] collision hs;

public static StaminaBar instance;



private void Awake()
{
    instance = this;
}
    
void Start()
{
       staminaBar.maxValue = stamina.stamina;
        healthBar.maxValue = hs.currentHealth;
}

void Update()
{
    staminaBar.value = stamina.stamina;
    healthBar.value = hs.currentHealth;
}

}
