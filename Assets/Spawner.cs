using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    [Tooltip("The Prefab to be spawned into the scene.")]
    public GameObject spawnPrefab = null;

    [Tooltip("The initial time between spawns")]
    public float initialSpawnTime = 5.0f;

    public float minSpawnTime = 0.5f;

    public float decreaseRate = 0.1f;

    [Tooltip("The time between spawns")]
    public float spawnTime = 5.0f;

    // keep track of time passed for next spawn
    private float nextSpawn = 0f;
    private float currentSpawnTime;

    // Start is called before the first frame update
    void Start()
    {
        nextSpawn = 0f;
        currentSpawnTime = initialSpawnTime;
    }

    // Update is called once per frame
    void Update()
    {
        // update the time until nextSpawn
        nextSpawn += Time.deltaTime;

        // if time to spawn
        if (nextSpawn > currentSpawnTime)
        {
            // Spawn the gameObject at the spawners current position and rotation
            GameObject projectileGameObject = Instantiate(spawnPrefab, transform.position, transform.rotation, null);

            // Decrease the spawn time
            currentSpawnTime = Mathf.Max(currentSpawnTime - decreaseRate, minSpawnTime);

            // reset the time until nextSpawn
            nextSpawn = 0f;
        }

    }
}
