using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FatherSound : MonoBehaviour
{
    [SerializeField] AudioSource _audioSource;
    [SerializeField] private AudioClip _clip;
    [SerializeField] float time;
    void Update()
    {
        FourthChace();
        Count();
    }

    void Count()
    {
        time += Time.deltaTime;
    }

    void FourthChace()
    {
        if (time >= 20f); // modificar por luego de leer la primera carta o por pasados los 15 min luego de leer la carta
        {
            _audioSource.Play();
            //Destroy(this, 2);
        }
    }
}
