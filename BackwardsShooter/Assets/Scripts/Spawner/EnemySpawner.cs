using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Dev: Roli Fanfaret
/// </summary>
public class EnemySpawner : SpawnerBase
{
    public class RandomSelection
    {
        public int value;
        public float probability;
        public bool wasLastTime = false;
        public bool shouldSpawn = true;

        public RandomSelection(int value, float probability)
        {
            this.value = value;
            this.probability = probability;
        }

        public int GetValue()
        {
            return value;
        }
    }

    public int enemyColumns = 3;
    public EnemyData enemyData;

    private List<RandomSelection> randomSelections = new List<RandomSelection>();
    private float startTime;
    private float endTime;

    private void Start()
    {
        for (int i = 0; i < enemyColumns; i++)
        {
            RandomSelection randomSelection = new RandomSelection(i, enemyData.spawnBigProbability);
            randomSelections.Add(randomSelection);
        }
    }

    private void HandleRandomValues()
    {
        float randomValue;

        foreach (RandomSelection selection in randomSelections)
        {
            randomValue = Random.value;

            selection.probability = enemyData.spawnSmallProbability;

            if (!selection.wasLastTime)
                selection.probability = enemyData.spawnBigProbability;

            if (randomValue <= selection.probability)
            {
                selection.shouldSpawn = true;
            }
            else
            {
                selection.shouldSpawn = false;
            }
        }
    }

    private void Update()
    {
        HandleRandomValues();

        if (Time.time >= endTime)
        {
            for (int i = 0; i < randomSelections.Count; i++)
            {
                if (randomSelections[i].shouldSpawn)
                {
                    GameObject spawnedGo = Spawn();
                    spawnedGo.transform.position = enemyData.spawnPositions[i];
                    randomSelections[i].wasLastTime = true;
                }
                else
                {
                    randomSelections[i].wasLastTime = false;
                }
            }

            endTime = Time.time + enemyData.delay;
        }
    }
}
