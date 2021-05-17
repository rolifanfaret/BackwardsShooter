using UnityEngine;

/// <summary>
/// Dev: Roli Fanfaret
/// </summary>
public class Bullet : MonoBehaviour
{
    public BulletData bulletData;

    private float speed;
    private Vector2 startPosition;

    private void Start()
    {
        speed = bulletData.speed;
        startPosition = transform.position;
        //Unparenting bullet because of the character movement.
        transform.SetParent(null);
    }

    private void Update()
    {
        transform.position += transform.right * Time.deltaTime * speed;

        if (Vector2.Distance(transform.position, startPosition) > bulletData.maxDistance)
            Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        EnemyController enemyController = collision.gameObject.GetComponent<EnemyController>();

        if (enemyController)
        {
            Destroy(enemyController.gameObject);
            ManagerRunner.IncrementCounter();
            Destroy(gameObject);
        }
    }


}
