using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PowerUp : MonoBehaviour
{
    public int inventory;

    public void OnTriggerEnter(Collider other)
    {
        // Destroy the PowerUp object
        Destroy(gameObject);
        Debug.Log("PowerUp picked up!");
        inventory = inventory++;
    }
}