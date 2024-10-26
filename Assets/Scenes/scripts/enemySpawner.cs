using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawner : MonoBehaviour
{
    [SerializeField] private Transform[] spawners;
    [SerializeField] private GameObject EnemyPrefab;
    [SerializeField] private float[] spawnIntervals;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < spawners.Length; i++)
        {
            StartCoroutine(SpawnEnemyOnIntervals(i));
        }
    }

    private IEnumerator SpawnEnemyOnIntervals(int index) 
    {
        while (true) 
        {
        yield return new WaitForSeconds(spawnIntervals[index]);
            Instantiate(EnemyPrefab, spawners[index].position,Quaternion.identity);
        }
    }
}
