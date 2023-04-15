using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Gun type", menuName = "ScriptableObjects/New Gun")]
public class GStatsSO : ScriptableObject
{
    //bullet
    public GameObject bullet;

    //bullet force
    public float shootForce, upwardForce;

    //gun stats
    public float TBShooting, spread, reloadT, TBShots;
    public int magSize, bulletsPerTap;
    public bool allowButtonHold;

    //recoil
    public float recoilForce;
    
}
