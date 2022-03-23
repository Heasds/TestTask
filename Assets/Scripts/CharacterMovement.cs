using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public WinLoseScreen winLose;
    private ChangeCharacterSptites characterSptites;
    private Rigidbody2D rigidbody2D;

    public Vector2 direction;
    public Vector2 lastDirection;

    private void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        characterSptites = GetComponent<ChangeCharacterSptites>();
    }

    public void Update()
    {
        rigidbody2D.MovePosition(rigidbody2D.position + direction * Time.fixedDeltaTime);
    }

    public void ChangeDirection(Vector2 newDirection)
    {
        direction = newDirection;
        lastDirection = new Vector2(0, 0);

        characterSptites.LookToDirection(newDirection);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Border")
        {
            lastDirection = direction;
            direction = new Vector2(0, 0);
        }
    }
}
