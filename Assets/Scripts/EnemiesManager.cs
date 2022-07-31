using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class EnemiesManager : MonoBehaviour
{
    public List<GameObject> enemiesList = new List<GameObject>();
    public float timeToSpawn = 5f; // acÃ¡ le pones el tiempo inicial que queres que tarde entre Spawn y Spawn

    private int currentEnemyIndex;
    private float currentTime;
    private bool canSpawn;
    
    
    void Start()
    {
        enemiesList = new List<GameObject>(Resources.LoadAll<GameObject>("Enemies"));
        canSpawn = true;
        currentTime = 0f;
        currentEnemyIndex = 0;
    }

    void Update()
    {
        //print(currentTime);
        if (canSpawn)
        {
            Timer();
        }
    }
	
    void Timer()
    {
        currentTime += Time.deltaTime;

        if (currentTime >= timeToSpawn)
        {
            SpawnNextEnemy();
            currentTime = 0f;
        }
    }
	
    void SpawnNextEnemy()
    {
        Instantiate(enemiesList[currentEnemyIndex], RandomPosition(), Quaternion.identity);
        currentEnemyIndex++;
		
        if (currentEnemyIndex >= enemiesList.Count)
        {
            canSpawn = false;
        }
    }
    
    Vector3 RandomPosition()
    {
        float numRandom = UnityEngine.Random.Range(-150f, 150f);
        return new Vector3(numRandom, 0, numRandom);
    }
}
