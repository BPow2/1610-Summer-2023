using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPowerUp : MonoBehaviour
{
    [SerializeField] private FloatData healthValue;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            //Apply the health value to the player
            ApplyHealth(other.gameObject);

            //Destroy the power-up game object
            Destroy(gameObject);
        }
    }
    private void ApplyHealth(GameObject player)
    {
        //Retrieve the palyers health component
        HealthController healthController = player.GetComponent<HealthController>();

        //Ceck if the player has a health component
        if(healthController != null)
        {
            //Add the health value to the player's current health
            healthController.Heal(healthValue.Value);
        }
    }

}
