using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnManager : MonoBehaviour
{
    public GameObject[] ufoPrefabs; //Array for UFOs

    private float spawnRangeX = 50f;
    private float spawnPosZ = 50f;

    private float startDelay = 2f;
    private float spawnInterval = 1.5f;

    void Start()
    {
        InvokeRepeating("SpawnRandomUFO", startDelay, spawnInterval);//spawns UFOs at random locations at the desired interval
    }

    void Update()
    {

    }

    void SpawnRandomUFO()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);//gives the range for UFO spawn position
        int ufoIndex = Random.Range(0, ufoPrefabs.Length); //pick a random UFO from the ufoPrefabs array
        Instantiate(ufoPrefabs[ufoIndex], spawnPos, ufoPrefabs[ufoIndex].transform.rotation); //Spawns UFO prefabs in a random location
    }
}
