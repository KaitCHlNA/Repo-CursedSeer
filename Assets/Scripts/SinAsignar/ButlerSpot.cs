using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class ButlerSpot : MonoBehaviour
{
    [SerializeField] private Transform butlerSpawn;
    private int numRandom;


    void Start()
    {
        numRandom = Random.Range(0, 40);
        butlerSpawn.transform.position = new Vector3(numRandom, 0, numRandom);
    }
}