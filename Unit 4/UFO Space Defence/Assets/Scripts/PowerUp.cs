using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PowerUp : MonoBehaviour
{
    public int inventory = 0;

    public string playerTag = "Player";

    public float topBounds;

    public float lowerBounds;

    void Update()
    {
        if (transform.position.z > topBounds)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBounds)
        {
            Destroy(gameObject);
        }
    }

    /*
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(playerTag))
        {
            // Destroy the PowerUp object
            inventory++;
            Destroy(gameObject);
            Debug.Log("PowerUp picked up!");
            Debug.Log("Power Ups Collected: " +  inventory);
        }
    }
    */
}