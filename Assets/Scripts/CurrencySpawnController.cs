using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrencySpawnController : MonoBehaviour
{
    public List<CurrencySpawnPosition> allSpawnPoses;
    public GameObject currencyPrefab;
    public float spawnDelay;

    private void Start()
    {
        StartCoroutine(SpawnCurrency());
    }

    private IEnumerator SpawnCurrency()
    {
        CurrencySpawnPosition newPos = GetNewPosition();
        GameObject currency = Instantiate(currencyPrefab, newPos.transform.position, Quaternion.identity);
        newPos.activeCurrency = currency;

        yield return new WaitForSeconds(spawnDelay);

        StartCoroutine(SpawnCurrency());
    }

    private CurrencySpawnPosition GetNewPosition()
    {
        CurrencySpawnPosition newPosition = new CurrencySpawnPosition();

        for (int i = 0; i < allSpawnPoses.Count; i++)
        {
            int rndm = Random.Range(0, allSpawnPoses.Count);

            if (allSpawnPoses[rndm].activeCurrency == null)
            {
                newPosition = allSpawnPoses[rndm];
            }
        }

        return newPosition;
    }
}
