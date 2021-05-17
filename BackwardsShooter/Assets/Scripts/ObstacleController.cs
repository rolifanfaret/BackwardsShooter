using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Dev: Roli Fanfaret
/// </summary>
public class ObstacleController : MonoBehaviour
{
    public ObstacleData obstacleData;

    private float speed;

    private void Start()
    {
        HandleDefaultPosition();

        SpriteRenderer spriteRenderer = GetComponentInChildren<SpriteRenderer>();

        if (spriteRenderer)
            spriteRenderer.sprite = obstacleData.sprite;
        else
            Debug.LogError(name + " Doesn't have an SpriteRenderer component", gameObject);

        speed = obstacleData.speed;
    }

    private void HandleDefaultPosition()
    {
        int randomValue = Random.Range(0, obstacleData.positions.Length);

        transform.position = obstacleData.positions[randomValue];
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Player player = collision.GetComponent<Player>();

        if(player != null)
        {
            if (collision == player.obstacleCollider)
            {
                SpeedUpAllEnemies();
                Destroy(gameObject);
            }
        }
    }

    private void SpeedUpAllEnemies()
    {
        EnemyController[] enemyControllers = FindObjectsOfType<EnemyController>();

        foreach(EnemyController enemyController in enemyControllers)
        {
            enemyController.SpeedUp();
        }
    }

    private void Update()
    {
        transform.position += transform.right * Time.deltaTime * speed;
    }
}
