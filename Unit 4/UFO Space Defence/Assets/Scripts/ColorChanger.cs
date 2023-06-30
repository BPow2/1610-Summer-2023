using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    public Material targetMaterial; // Reference to the material you want to change

    private float timer = 0f; // Timer to track the elapsed time
    private float interval = 0.5f; // Time interval to change color (in seconds)

    private void Update()
    {
        // Update the timer
        timer += Time.deltaTime;

        // Check if it's time to change color
        if (timer >= interval)
        {
            // Generate a random color
            Color newColor = Random.ColorHSV();

            // Change the color of the material
            if (targetMaterial != null)
            {
                targetMaterial.color = newColor;
            }

            // Reset the timer
            timer = 0f;
        }
    }
}
