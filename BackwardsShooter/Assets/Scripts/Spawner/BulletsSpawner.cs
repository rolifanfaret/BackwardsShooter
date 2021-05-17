using UnityEngine;

/// <summary>
/// Dev: Roli Fanfaret
/// </summary>
public class BulletsSpawner : SpawnerBase
{
    public BulletData bulletData;

    private float speed;
    private float delay;

    private void Start()
    {
        delay = bulletData.nextBulletDelay;

        InvokeRepeating(nameof(SpawnBullet), 0, delay);
    }

    private void SpawnBullet()
    {
        Spawn();
    }
}
