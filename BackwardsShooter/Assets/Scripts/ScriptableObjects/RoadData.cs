using UnityEngine;

/// <summary>
/// Dev: Roli Fanfaret
/// </summary>
[CreateAssetMenu(menuName = "Data/RoadData")]
public class RoadData : ScriptableObject
{
    public Vector2 startPosition;
    public Vector2 endPosition;
    public float speed;
    public float distance;
}