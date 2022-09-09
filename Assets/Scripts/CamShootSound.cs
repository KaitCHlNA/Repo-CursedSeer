using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class CamShootSound : MonoBehaviour
{
    public AudioSource _audioSourceCam;

    public void PhotoSound()
    {
        if (Input.GetMouseButton(0))
        {
            _audioSourceCam.Play();
            _audioSourceCam.pitch = Random.Range(0.95f, 1.5f);
        }
    }
}
