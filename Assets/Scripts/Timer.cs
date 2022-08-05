using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public static float currentTime;
    
    void Update()
    {
        currentTime += Time.deltaTime;
    }
}
