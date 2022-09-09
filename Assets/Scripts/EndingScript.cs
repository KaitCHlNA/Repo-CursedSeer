using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EndingScript : MonoBehaviour
{
    [SerializeField] private UnityEvent nearCar;
    
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player") && Input.GetKeyDown(KeyCode.E))
        {
            nearCar.Invoke();
        }
    }
}
