using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{
    public int currentAmmo;

    private void Start()
    {
        currentAmmo = 100;
    }

    public void AddAmmo(float AmmoAmount)
    {
        currentAmmo += (int)AmmoAmount;

        Debug.Log("Player's Ammo Count: " + currentAmmo);
    }
}
