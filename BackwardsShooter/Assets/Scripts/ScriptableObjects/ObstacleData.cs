using UnityEngine;

/// <summary>
/// Dev: Roli Fanfaret
/// </summary>
[CreateAssetMenu(menuName = "Data/ObstacleData")]
public class ObstacleData : ScriptableObject
{
    public Sprite sprite;
    public float speed;
    public Vector2 delayRange;
    public Vector2[] positions;
}
