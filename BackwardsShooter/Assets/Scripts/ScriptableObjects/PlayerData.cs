using UnityEngine;

/// <summary>
/// Dev: Roli Fanfaret
/// </summary>
[CreateAssetMenu(menuName = "Data/PlayerData")]
public class PlayerData : ScriptableObject
{
    public Sprite sprite;
    public float movementDistance;
    public float maxMoveTime;
    public float winScore;
    public Vector2 upPosition;
    public Vector2 midPosition;
    public Vector2 downPosition;
}
