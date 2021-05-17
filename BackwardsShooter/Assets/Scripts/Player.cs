using UnityEngine;

/// <summary>
/// Dev: Roli Fanfaret
/// </summary>
public class Player : MonoBehaviour
{
    public PlayerData playerData;
    public Collider2D enemyCollider;
    public Collider2D obstacleCollider;

    private enum PlayerPhase { Down, Middle, Up };
    private PlayerPhase playerPosition = PlayerPhase.Middle;
    private Vector2 initialPosition;
    private float currentTime;
    private float endTime;

    private void Start()
    {
        GetComponent<SpriteRenderer>().sprite = playerData.sprite;
    }

    private void MovePlayer()
    {
        if (playerPosition == PlayerPhase.Up)
            transform.position = playerData.upPosition;
        if (playerPosition == PlayerPhase.Middle)
            transform.position = playerData.midPosition;
        if (playerPosition == PlayerPhase.Down)
            transform.position = playerData.downPosition;
    }

    private void MoveUp()
    {
        if (playerPosition == PlayerPhase.Up)
            return;

        if (playerPosition == PlayerPhase.Middle)
            playerPosition = PlayerPhase.Up;
        else
            playerPosition = PlayerPhase.Middle;
    }

    private void MoveDown()
    {
        if (playerPosition == PlayerPhase.Down)
            return;

        if (playerPosition == PlayerPhase.Middle)
            playerPosition = PlayerPhase.Down;
        else
            playerPosition = PlayerPhase.Middle;

    }

    private void HandleMovement()
    {
        initialPosition = Input.mousePosition;
        endTime = currentTime + playerData.maxMoveTime;
    }

    void Update()
    {
        currentTime = Time.time;
        Vector2 currentPosition = Input.mousePosition;

        if(Input.GetMouseButtonDown(0))
        {
            HandleMovement();
        }

        if (Input.GetMouseButton(0))
        {
            if (currentTime > endTime)
            {
                initialPosition = currentPosition;
                endTime = currentTime + playerData.maxMoveTime;
            }

            float distance = currentPosition.y - initialPosition.y;
            float distanceAbs = Mathf.Abs(distance);

            if (distanceAbs >= playerData.movementDistance)
            {
                if (distance < 0)
                {
                    MoveDown();
                }
                else
                {
                    MoveUp();
                }
                HandleMovement();
                MovePlayer();
            }
        }
    }
}
