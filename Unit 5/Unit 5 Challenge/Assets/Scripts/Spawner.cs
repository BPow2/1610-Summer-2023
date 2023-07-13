using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    private float nextSpawnTime;

    [SerializeField] private GameObject Prefab;

    [SerializeField] private float spawnDelay = 5f;

    private void Update()
    {
        if (ShouldSpawn())
        {
            Spawn();
        }
    }

    private void Spawn ()
    {
        nextSpawnTime = Time.time + spawnDelay;
        Instantiate(Prefab, transform.position, transform.rotation);
    }

    private bool ShouldSpawn()
    {
        return Time.time >= nextSpawnTime;
    }

}
