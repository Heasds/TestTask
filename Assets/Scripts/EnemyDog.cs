using UnityEngine;

public class EnemyDog : Enemy
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<CharacterHp>() != null)
        {
            farmerHP.GetDamage(farmerDamage);
            collision.GetComponent<CharacterHp>().GetDamage(characterDamage);
        }
        if (collision.tag == "Bomb")
        {
            farmerHP.GetDamage(farmerDamage);
            Destroy(collision.gameObject);
        }

        Destroy(gameObject);
    }
}
