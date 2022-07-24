using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundOfBackground : MonoBehaviour
{
    [SerializeField] AudioSource _audioSource;
    [SerializeField] AudioClip _audioClip;

    void OnCollisionEnter(Collision backInHouse)
    {
        if(backInHouse.gameObject.CompareTag("Player")) _audioSource.volume = 0.1f;
    }
}
