using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShopManager : MonoBehaviour
{
    public CurrencyController currencyController;
    public List<Product> products;

    private void Start()
    {
        for (int i = 0; i < products.Count; i++)
        {
            Product product = products[i];
            
            product.countText.text = product.count.ToString();
        }
    }

    public void BuyProductButton(string productName)
    {
        for (int i = 0; i < products.Count; i++)
        {
            if (products[i].name == productName)
            {
                Product product = products[i];

                if (currencyController.currencyCount - product.price >= 0)
                {
                    currencyController.RemoveCurrency(product.price);

                    product.count++;
                    product.countText.text = product.count.ToString();
                }
            }
        }
    }

}
[System.Serializable]
public class Product
{
    public string name;
    public int price;
    public int count;
    public TextMeshProUGUI countText;
}
