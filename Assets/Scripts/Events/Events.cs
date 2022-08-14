using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Events : MonoBehaviour
{
    public static event Action testEvent; 
    public static event Action testEventTwo;

    void Start()
    {
        print("Press Left Click");
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            testEvent?.Invoke();
            print(this);
        }
        
        if (Input.GetMouseButtonDown(1))
        {
            testEventTwo?.Invoke();
            print(this);
        }
    }
}
