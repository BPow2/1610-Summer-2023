using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DetectCollision : MonoBehaviour
{
    public ScoreManager scoreManager; //reference to the ScoreManager script

    public int scoreToGive;//varible for how much score player gets for defeating this UFO

    public int sceneToLoad; // var for picking next scene

    private void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();//gets score manager
    }

    private void OnTriggerEnter(Collider other) //collision trigger for UFOs
    {
        if (other.CompareTag("Player"))
        {
            scoreManager.IncreaseScore(scoreToGive); //increases score based on score to give
            Destroy(gameObject); // destroys this game object
            Destroy(other.gameObject); //destroys collided object
            SceneManager.LoadScene(sceneToLoad);//load var scene (Game Over Scene)
        }

        if(other.CompareTag("Laser"))
        {
            scoreManager.IncreaseScore(scoreToGive); //increases score based on score to give
            Destroy(gameObject); // destroys this game object
            Destroy(other.gameObject); //destroys collided object
        }
    }
}
