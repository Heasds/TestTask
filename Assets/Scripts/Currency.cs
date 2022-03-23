using UnityEngine;

public class Currency : MonoBehaviour
{
    private CurrencyController currencyController;

    private void Start()
    {
        currencyController = GameObject.FindGameObjectWithTag("UI Managers").GetComponent<CurrencyController>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<CharacterMovement>() != null)
        {
            currencyController.AddCurrency(1);
            Destroy(gameObject);
        }
    }
}
