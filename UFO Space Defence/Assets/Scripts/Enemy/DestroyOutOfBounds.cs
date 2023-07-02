 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float topBounds; //var for top boundary

    public float lowerBounds;// var for bottom boundary

    public int sceneToLoad; // var for picking next scene

    private void Awake()
    {
        Time.timeScale = 1; //sets time
    }

    void Update()
    {
        if (transform.position.z > topBounds) //if this object goes over the top boundary destroy this object
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBounds)// if this object goes below the bottom boundary...
        {
            Destroy(gameObject);//destroy this game object
            Debug.Log("Game Over");
            Time.timeScale = 0;//stop time
            SceneManager.LoadScene(sceneToLoad);//load var scene (Game Over Scene)
        }
    }
}
