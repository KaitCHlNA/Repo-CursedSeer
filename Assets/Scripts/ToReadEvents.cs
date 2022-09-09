using System;
using UnityEngine;
using UnityEngine.Events;

public class ToReadEvents : MonoBehaviour
{
    [SerializeField] private UnityEvent enterReadingEvents;
    [SerializeField] private UnityEvent startReadingEvents;
    [SerializeField] private UnityEvent stopReadingEvents;

    //public NotesDisplay _Display;
    private bool isPressing;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            isPressing = true;
        }

        if (Input.GetKeyUp(KeyCode.E))
        {
            isPressing = false;
        }
    }
    
    private void OnTriggerEnter(Collider enter)
    {
        if (enter.CompareTag("Player"))
        {
            enterReadingEvents.Invoke();
        }
    }
    
    void OnTriggerStay(Collider reading)
    {
        if (reading.CompareTag("Player") && isPressing)
        {
            startReadingEvents.Invoke();
            //_Display.ShowMessage();
        }
    }
    

    private void OnTriggerExit(Collider notReading)
    {
        if (notReading.CompareTag("Player"))
        {
            stopReadingEvents.Invoke();
        }
    }
}
