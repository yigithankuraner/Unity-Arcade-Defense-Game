using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;
    public GameObject powerUpPrefab;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
    private float minSpawnInterval = 3.0f;
    private float maxSpawnInterval = 5.0f;
    private float acceleration = 0.1f;

    private bool canSpawnPowerUp = true;

    void Start()
    {
        Invoke("SpawnRandomBall", startDelay);
    }

    void SpawnRandomBall()
    {
        if (GameManagerX.Instance != null && !GameManagerX.Instance.isGameActive)
        {
            return;
        }

        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        if (Random.value < 0.25f && powerUpPrefab != null && canSpawnPowerUp)
        {
            Instantiate(powerUpPrefab, spawnPos, powerUpPrefab.transform.rotation);
            canSpawnPowerUp = false;
            StartCoroutine(PowerUpCooldown());
        }
        else
        {
            int ballIndex = Random.Range(0, ballPrefabs.Length);
            Instantiate(ballPrefabs[ballIndex], spawnPos, ballPrefabs[ballIndex].transform.rotation);
        }

        if (minSpawnInterval > 0.5f)
        {
            minSpawnInterval -= acceleration;
        }

        if (maxSpawnInterval > 1.0f)
        {
            maxSpawnInterval -= acceleration;
        }

        float randomInterval = Random.Range(minSpawnInterval, maxSpawnInterval);
        Invoke("SpawnRandomBall", randomInterval);
    }

    IEnumerator PowerUpCooldown()
    {
        yield return new WaitForSeconds(10.0f);
        canSpawnPowerUp = true;
    }
}