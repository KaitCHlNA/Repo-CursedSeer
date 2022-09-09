using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Timer : MonoBehaviour
{
    //public static float currentTime;
    public static float timeInEntireGame;

    void Start()
    {
        timeInEntireGame = 0f;
    }

    void Update()
    {
        timeInEntireGame += Time.deltaTime;
    }
}
