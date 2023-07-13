using UnityEngine;

public class HealthController : MonoBehaviour
{
    public int currentHealth;

    private void Start()
    {
        // Initialize the player's health
        currentHealth = 100;
    }

    public void Heal(float healAmount)
    {
        // Increase the player's health
        currentHealth += (int)healAmount;

        // Display the updated health value
        Debug.Log("Player's health: " + currentHealth);
    }
}

