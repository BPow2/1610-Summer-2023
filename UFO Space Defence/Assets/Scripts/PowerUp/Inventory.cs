using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public int powerUpCount = 0;

    public string powerUpTag = "PowerUp";

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(powerUpTag))
        {
            // Increment power-up count
            powerUpCount++;

            // Destroy the collected power-up object
            Destroy(other.gameObject);

            // Debug print the power-up count (optional)
            Debug.Log("Power-Up Count: " + powerUpCount);
        }
    }
}
