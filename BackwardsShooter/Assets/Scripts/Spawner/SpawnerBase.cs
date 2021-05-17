using UnityEngine;

/// <summary>
/// Dev: Roli Fanfaret
/// </summary>
public class SpawnerBase : MonoBehaviour
{
    private GameObject lastSpawnedGo;

    public GameObject spawnGameObject;
    public Transform parentTransform;

    public GameObject LastSpawnedItem
    {
        get
        {
            return lastSpawnedGo;
        }
    }
    public virtual GameObject Spawn()
    {
        lastSpawnedGo = Instantiate(spawnGameObject, parentTransform);
        return lastSpawnedGo;
    }

}
