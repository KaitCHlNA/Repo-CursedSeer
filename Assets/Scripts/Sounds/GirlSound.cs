using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GirlSound : MonoBehaviour
{
    [SerializeField] AudioSource _audioSource;
    [SerializeField] private AudioClip _clip;
    [SerializeField] float time;
    void Update()
    {
        SecondChace();
        Count();
    }

    void Count()
    {
        time += Time.deltaTime;
    }

    void SecondChace()
    {
        if (time >= 10f); // modificar por luego de leer la primera carta o por pasados los 5 min luego de leer la carta
        {
            _audioSource.Play();
            //Destroy(this, 2);
        }
    }
}
