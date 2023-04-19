using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerTest : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            StaminaBar.instance.UseStamina(15);;
        }
    }
}