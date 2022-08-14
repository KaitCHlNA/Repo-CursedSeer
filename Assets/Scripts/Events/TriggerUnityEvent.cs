using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerUnityEvent : MonoBehaviour
{
    [SerializeField] private UnityEvent aTrigger;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            aTrigger.Invoke();
            print(this);
        }
    }
}
