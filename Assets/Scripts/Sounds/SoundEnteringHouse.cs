using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SoundEnteringHouse : MonoBehaviour
{
    [SerializeField] AudioSource _audioSource;
    [SerializeField] AudioClip _clip;
   
    void OnCollisionEnter(Collision enter)
    {
        if (enter.gameObject.CompareTag("Player")) _audioSource.Play();
    }
}
