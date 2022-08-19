using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class ArtefactsManager : MonoBehaviour
{
    public List<GameObject> artefactsList = new List<GameObject>();
    public List<Transform> spawnList = new List<Transform>();
    public float timeToSpawn = 5f; // idem al spawn de enemigos

    private int currentArtefactIndex;
    private float currentTime;
    private bool canSpawn;

    void Start()
    {
        artefactsList = new List<GameObject>(Resources.LoadAll<GameObject>("Artefacts"));
        spawnList = new List<Transform>(gameObject.GetComponentsInChildren<Transform>());
        spawnList.Remove(transform);
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
            Spawn();
            currentTime = 0f;
        }
    }

    void Spawn()
    {
        Instantiate(artefactsList[currentArtefactIndex], spawnList[currentArtefactIndex].position, Quaternion.identity);
        currentArtefactIndex++;
        
        if (currentArtefactIndex >= artefactsList.Count)
        {
            canSpawn = false;
        }
    }
}
