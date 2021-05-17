using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Dev: Roli Fanfaret
/// </summary>
public class ObjectKiller : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject collisionGo = collision.gameObject;

        Destroy(collisionGo);
    }
}
