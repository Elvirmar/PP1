using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemies;
    public GameObject[] powerUps;
    public GameObject[] floors;

    private float xSpawnRange = 5.5f;
    public float ySpawnRange = 0.75f;
    private float zSpawnPosition = 10.0f;

    public float enemiesSpawnTime = 1.5f;
    private float powerUpsSpawnTime = 4.0f;
    private float startDelay = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomEnemies", startDelay, enemiesSpawnTime);
        InvokeRepeating("SpawnRandomPowerUps", startDelay, powerUpsSpawnTime);
        SpawnRandomPowerUps();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnRandomEnemies ()
    {
        float randomX = Random.Range(-xSpawnRange, xSpawnRange);
        int randomIndex = Random.Range ( 0, enemies.Length );

        Vector3 spawnPos = new Vector3(randomX,ySpawnRange,zSpawnPosition);

        Instantiate(enemies[randomIndex], spawnPos, enemies[randomIndex].gameObject.transform.rotation);
    }
    void SpawnRandomPowerUps()
    {
        float randomX = Random.Range(-xSpawnRange, xSpawnRange);
        int randomIndex = Random.Range(0, powerUps.Length);

        Vector3 spawnPos = new Vector3(randomX, ySpawnRange, zSpawnPosition);

        Instantiate(powerUps[randomIndex], spawnPos, powerUps[randomIndex].gameObject.transform.rotation);
    }
}
