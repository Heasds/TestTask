using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public WinLoseScreen winLose;
    public List<Transform> enemySpawnPos;
    public GameObject enemyPrefab;
    public float spawnDelay;

    void Start()
    {
        StartCoroutine(Spawner());
    }

    private IEnumerator Spawner()
    {
        SpawnNewEnemy();
        yield return new WaitForSeconds(spawnDelay);
        StartCoroutine(Spawner());
    }

    private void SpawnNewEnemy()
    {
        int rndm = Random.Range(0, enemySpawnPos.Count);
        Enemy newEnemy = Instantiate(enemyPrefab, enemySpawnPos[rndm].position, Quaternion.identity).GetComponent<Enemy>();

        newEnemy.farmerHP = GetComponent<FarmerHP>();
    }
}
