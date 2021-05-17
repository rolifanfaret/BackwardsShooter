using UnityEngine;

/// <summary>
/// Dev: Roli Fanfaret
/// </summary>
[CreateAssetMenu(menuName = "Data/EnemyData")]
public class EnemyData : ScriptableObject
{
    public Sprite sprite;
    public float speed;
    public float addSpeed;
    public float addSpeedTime;
    public float delay;
    public float spawnSmallProbability;
    public float spawnBigProbability;
    public Vector2[] spawnPositions;
}
