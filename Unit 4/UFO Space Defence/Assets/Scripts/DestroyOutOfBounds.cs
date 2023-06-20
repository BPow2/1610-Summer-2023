using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float topBounds;

    public float lowerBounds;

    private void Awake()
    {
        //Time.timeScale = 1;
    }

    void Update()
    {
        if (transform.position.z > topBounds) 
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBounds)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
            //Time.timeScale = 0;
        }
    }
}
