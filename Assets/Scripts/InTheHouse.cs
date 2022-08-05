using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InTheHouse : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private AudioClip clipInTheHouse;

    private float lessVolume = 0.5f;

    private void Start()
    {
        _audioSource.clip = clipInTheHouse;
    }

    private void OnTriggerEnter(Collider enter)
    {
        if (enter.gameObject.transform.tag == "Enter")
        {
            _audioSource.Play();
            //controlar volume al salir de casa
        }
    }

    private void OnTriggerExit(Collider exit)
    {
        if (exit.gameObject.transform.tag == "Exit")
        {
            _audioSource.volume = lessVolume;
        }
    }
}
