using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Experimental.GlobalIllumination;

public class HugeDoll : MonoBehaviour
{
    [SerializeField] private UnityEvent hehe;
    [SerializeField] private UnityEvent hehent;

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player") && Input.GetMouseButtonDown(0))
        {
            hehe.Invoke();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            hehent.Invoke();
        }
    }
}
