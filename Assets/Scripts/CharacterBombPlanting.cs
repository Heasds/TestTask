using UnityEngine;

public class CharacterBombPlanting : MonoBehaviour
{
    public GameObject bombPrefab;
    public ShopManager shop;

    public void BombButton()
    {
        for (int i = 0; i < shop.products.Count; i++)
        {
            if (shop.products[i].name == "Bomb")
            {
                if (shop.products[i].count > 0)
                {
                    shop.products[i].count--;
                    shop.products[i].countText.text = shop.products[i].count.ToString();
                    Instantiate(bombPrefab, transform.position, Quaternion.identity);
                }
            }
        }

    }
}
