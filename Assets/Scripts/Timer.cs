using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] private float currentTime;
    
    void Update()
    {
        currentTime += Time.deltaTime;
    }
}
