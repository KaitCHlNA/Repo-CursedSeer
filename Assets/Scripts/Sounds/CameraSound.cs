using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class CameraSound : MonoBehaviour
{
    [SerializeField] AudioSource _audioSource;
    [SerializeField] AudioClip _clip;
  
    void Update()
    {
        Shoot();
    }

    void Shoot()
    {
        if (Input.GetMouseButton(0))
        {
            _audioSource.Play();
            _audioSource.pitch = Random.Range(0.9f, 1.1f);
        }
    }
}
