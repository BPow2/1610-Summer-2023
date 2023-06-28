using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject); //Destroy this game object
        Destroy(other.gameObject); //Destroy hit object
    }
}
