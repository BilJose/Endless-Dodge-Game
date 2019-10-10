using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy;
    public float xPositionLimit;
    public float spawnRate;


    // Start is called before the first frame update
    void Start()
    {
        //SpawnSpike
        StartSpawning();
    }
    void SpawnSpike()
    {
        float xRandom = Random.Range(-xPositionLimit, xPositionLimit);

        Vector2 spawnPosition = new Vector2(xRandom, transform.position.y);
        Instantiate(enemy, spawnPosition, Quaternion.identity);
    }
    public void StartSpawning()
    {
        InvokeRepeating("SpawnSpike", 1f, spawnRate);
    }
    public void StopSpawning()
    {
        CancelInvoke("SpawnSpike");
    }

}
