using UnityEngine;
using UnityEngine.UI;

public class DisplayInventory : MonoBehaviour
{
    public Text variableText;
    public PowerUp powerUp;

    public void Update()
    {
        // Get the amount of power ups collected from the PowerUp script
        int inventory = powerUp.inventory;
        int scoreValue = inventory;

        variableText.text = "You have collected: " + scoreValue.ToString() + "Power Ups.";
    }
}
