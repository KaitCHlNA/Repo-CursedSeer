using System;
using UnityEngine;
using Random = System.Random;

public class ButtonSound : MonoBehaviour
{
    public AudioSource buttonAS;
    public AudioClip clickclip;

    void Start()
    {
        buttonAS.clip = clickclip;
    }

    public void PlayClickSound()
    {
        buttonAS.pitch = UnityEngine.Random.Range(0.9f, 1f);
        buttonAS.Play();
    }
}
