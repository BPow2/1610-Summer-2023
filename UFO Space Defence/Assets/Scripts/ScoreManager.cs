using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{

    public int score; //Keep score

    public TextMeshProUGUI scoreText; //Visualize Text

    public void IncreaseScore(int amount) // increases the score
    {
        score += amount;
        UpdateScoreText();
    }

    public void DecreaseScore(int amount)// Decreases the score
    {
        score -= amount;
        UpdateScoreText();
    }

    public void UpdateScoreText() // Update the score in the HUD
    {
        scoreText.text = "Score: "  + score;
    }
}
