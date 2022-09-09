using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InTheHouse : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private AudioSource audEnviroment;

    private float lessVolume = 0.15f;
    
    private void OnTriggerEnter(Collider enter)
    {
        if (enter.CompareTag("Player"))
        {
            _audioSource.Play();
            audEnviroment.volume = lessVolume;
        }
    }

    private void OnTriggerExit(Collider exit)
    {
        if (exit.CompareTag("Player"))
        {
            Vector3 newPos = new Vector3(0, -10, 0);
            gameObject.transform.position = newPos;
        }
    }
    
}
