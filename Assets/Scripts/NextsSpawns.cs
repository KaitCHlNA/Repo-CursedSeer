using System;
using System.Collections;
using System.Collections.Generic;
using System.IO.Compression;
using UnityEngine;

public class NextsSpawns : MonoBehaviour
{
    public GameObject goSecondSpawn;
    public GameObject goThirdSpawn;
    public GameObject goFourthSpawn;

    void Update()
    {
        GO2Spawner();
        GO3Spawner();
        GO4Spawner();
    }
    

    public void GO2Spawner()
    {
        if (Timer.timeInEntireGame >= 180f)
        {
            goSecondSpawn.SetActive(true);
        }
    }

    public void GO3Spawner()
    {
        if (Timer.timeInEntireGame >= 360f)
        {
            goThirdSpawn.SetActive(true);
        }
    }

    public void GO4Spawner()
    {
        if (Timer.timeInEntireGame >= 540f)
        {
            goFourthSpawn.SetActive(true);
        }
    }
}
