using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButlerSound : MonoBehaviour
{
    [SerializeField] AudioSource _audioSource;
    [SerializeField] private AudioClip _clip;
    [SerializeField] float time;
    void Update()
    {
        FirstChace();
        Count();
    }

    void Count()
    {
        time += Time.deltaTime;
    }

    void FirstChace()
    {
        if (time >= 5f); // modificar por luego de leer la primera carta
        {
            _audioSource.Play();
            //Destroy(this, 2);
        }
    }
}
