using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Rigidbody2D rigidbody;
    [HideInInspector] public FarmerHP farmerHP;
    private Vector2 direction;

    public float farmerDamage;
    public float characterDamage;

    void Start()
    {
        direction = new Vector2(-1, 0);
        rigidbody = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        EnemyMove();
    }

    private void EnemyMove()
    {
        rigidbody.MovePosition(rigidbody.position + direction * Time.deltaTime);
    }
}
