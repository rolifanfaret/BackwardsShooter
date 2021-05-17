using UnityEngine;

/// <summary>
/// Dev: Roli Fanfaret
/// </summary>
[CreateAssetMenu(menuName = "Data/BulletData")]
public class BulletData : ScriptableObject
{
    public float speed;
    public float nextBulletDelay;
    public float maxDistance;
}
