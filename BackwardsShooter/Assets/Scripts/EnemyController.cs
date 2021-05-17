using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Dev: Roli Fanfaret
/// </summary>
public class EnemyController : MonoBehaviour
{
    public EnemyData enemyData;
    public string playerLayer = "Player";

    private float speed;

    void Start()
    {
        speed = enemyData.speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject collisionGo = collision.gameObject;

        if (collisionGo.layer == LayerMask.NameToLayer(playerLayer))
        {
            ManagerRunner.GetGameOverGameObject().SetActive(true);
        }
    }

    public void SpeedUp()
    {
        speed += enemyData.addSpeed;

        Invoke(nameof(StopSpeedUp), enemyData.addSpeedTime);
    }

    private void StopSpeedUp()
    {
        speed = enemyData.speed;
    }

    void Update()
    {
        transform.position += -transform.right * Time.deltaTime * speed;
    }
}
