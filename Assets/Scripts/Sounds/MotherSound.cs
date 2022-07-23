using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotherSound : MonoBehaviour
{
    [SerializeField] AudioSource _audioSource;
    [SerializeField] private AudioClip _clip;
    [SerializeField] float time;
    void Update()
    {
        ThirdChace();
        Count();
    }

    void Count()
    {
        time += Time.deltaTime;
    }

    void ThirdChace()
    {
        if (time >= 15f); // modificar por luego de leer la primera carta o por pasados los 10 min luego de leer la carta
        {
            _audioSource.Play();
            //Destroy(this, 2);
        }
    }
}
