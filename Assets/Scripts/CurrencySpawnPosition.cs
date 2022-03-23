using UnityEngine;

public class CurrencySpawnPosition : MonoBehaviour
{
    public GameObject activeCurrency;

    public float destroyDelay;
    private float destroyTimer;

    private void Start()
    {
        destroyTimer = destroyDelay;
    }

    private void Update()
    {
        if (activeCurrency != null)
        {
            if (destroyTimer > 0)
            {
                destroyTimer -= Time.deltaTime;
            }
            else
            {
                Destroy(activeCurrency);
                destroyTimer = destroyDelay;
            }
        }    
    }
}
