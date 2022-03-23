using UnityEngine;
using TMPro;

public class CurrencyController : MonoBehaviour
{
    public TextMeshProUGUI text;
    public int currencyCount;

    private void Start()
    {
        text.text = currencyCount.ToString();
    }

    public void AddCurrency(int count)
    {
        currencyCount += count;
        text.text = currencyCount.ToString();
    }  
    
    public void RemoveCurrency(int count)
    {
        currencyCount -= count;
        text.text = currencyCount.ToString();
    }

}
