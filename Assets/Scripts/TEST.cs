using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class TEST : MonoBehaviour
{
   
    public GameObject[] artefacts = new GameObject[4];
    [SerializeField] private GameObject leoPref, teddyPref, gramPref, shoesPref;
    private int currentArtefactIndex;
    
    public Transform[] artefactSpots = new Transform[4];
    [SerializeField] private Transform leoSpawn, teddySpawn, gramSpawn, shoesSpawn;
    private int currentArtefactSpotIndex;

    public float timeToSpawn = 5f; // acÃ¡ le pones el tiempo inicial que queres que tarde entre Spawn y Spawn
    
    private float currentTime;
    private bool canSpawn;
    
    
    void Start()
    {
        canSpawn = true;
        currentTime = 0f;
        currentArtefactIndex = 0;
    }

    void Update()
    {
        print(currentTime);
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
            SpawnNextArtefact();
            currentTime = 0f;
        }
    }
	
    void SpawnNextArtefact()
    {
        Instantiate(artefacts[currentArtefactIndex], RandomPosition(), Quaternion.identity);
        currentArtefactIndex++;

        if (currentArtefactIndex >= artefacts.Length)
        {
            canSpawn = false;
        }
    }
    
    void SpawnNextSpot()
    {
        //artefactSpots.Length[];
        currentArtefactSpotIndex++;

        if (currentArtefactIndex >= artefactSpots.Length)
        {
            canSpawn = false;
        }
    }
    
    Vector3 RandomPosition()
    {
        float numRandom = UnityEngine.Random.Range(0f, 50f);
        return new Vector3(numRandom, 0f, numRandom);
    }
}
