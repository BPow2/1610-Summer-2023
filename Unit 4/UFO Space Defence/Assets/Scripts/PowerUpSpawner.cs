using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject powerUp;

    private float spawnRangeX = 50f;
    private float spawnPosZ = 50f;

    private float startDelay = 2f;
    private float spawnInterval = 1.5f;

    void Start()
    {
        InvokeRepeating("SpawnPowerUp", startDelay, spawnInterval);
    }

    void Update()
    {

    }

    void SpawnPowerUp()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        Instantiate(powerUp, spawnPos, powerUp.transform.rotation);
    }
}
