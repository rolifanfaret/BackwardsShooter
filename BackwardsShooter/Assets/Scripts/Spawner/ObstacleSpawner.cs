using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Dev: Roli Fanfaret
/// </summary>
public class ObstacleSpawner : SpawnerBase
{
    public ObstacleData obstacleData;

    private Vector2 delayRange;
    private float delay;

    void Start()
    {
        delayRange = obstacleData.delayRange;
        delay = Random.Range(delayRange.x, delayRange.y);

        StartCoroutine(HandleSpawn());
    }

    private IEnumerator HandleSpawn()
    {
        yield return new WaitForSeconds(delay);

        while (true)
        {
            Spawn();

            delay = Random.Range(delayRange.x, delayRange.y);

            yield return new WaitForSeconds(delay);
        }
    }

}
