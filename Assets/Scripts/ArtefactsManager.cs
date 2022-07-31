using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class ArtefactsManager : MonoBehaviour
{
    public List<GameObject> artefactsList = new List<GameObject>();
    public float timeToSpawn = 5f; // idem al spawn de enemigos

    private int currentArtefactIndex;
    private float currentTime;
    private bool canSpawn;

    [SerializeField] private Transform leoSpot;
    [SerializeField] private Transform teddySpot;
    [SerializeField] private Transform gramSpot;
    [SerializeField] private Transform shoesSpot;

    void Start()
    {
        artefactsList = new List<GameObject>(Resources.LoadAll<GameObject>("Artefacts"));
        canSpawn = true;
        currentTime = 0f;
        currentArtefactIndex = 0;
    }

    void Update()
    {
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
            LeoSpawn();
            currentTime = 0f;
        }
        if (currentTime >= timeToSpawn)
        {
            TeddySpawn();
            currentTime = 0f;
        }
        if (currentTime >= timeToSpawn)
        {
            GramSpawn();
            currentTime = 0f;
        }
        if (currentTime >= timeToSpawn)
        {
            ShoesSpawn();
            currentTime = 0f;
        }
    }
    

    void LeoSpawn()
    {
        Instantiate(artefactsList[currentArtefactIndex], leoSpot.position, Quaternion.identity);
        currentArtefactIndex++;
        
        if (currentArtefactIndex >= artefactsList.Count)
        {
            canSpawn = false;
        }
    }
    
    void TeddySpawn()
    {
        Instantiate(artefactsList[currentArtefactIndex], teddySpot.position, Quaternion.identity);
        currentArtefactIndex++;
        
        if (currentArtefactIndex >= artefactsList.Count)
        {
            canSpawn = false;
        }
    }
    
    void GramSpawn()
    {
        Instantiate(artefactsList[currentArtefactIndex], gramSpot.position, Quaternion.identity);
        currentArtefactIndex++;
        
        if (currentArtefactIndex >= artefactsList.Count)
        {
            canSpawn = false;
        }
    }
    
    void ShoesSpawn()
    {
        Instantiate(artefactsList[currentArtefactIndex], shoesSpot.position, Quaternion.identity);
        currentArtefactIndex++;
        
        if (currentArtefactIndex >= artefactsList.Count)
        {
            canSpawn = false;
        }
    }
}

