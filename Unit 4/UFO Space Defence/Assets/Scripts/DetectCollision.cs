using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{

    public string powerUpTag = "PowerUp";

    public string enemyTag = "Enemy";

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag(powerUpTag) || !other.CompareTag(enemyTag))
        {
            Destroy(gameObject); //Destroy this game object
            Destroy(other.gameObject); //Destroy hit object
        }
    }
}
