using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemyNearSound : MonoBehaviour
{
    [SerializeField] AudioSource _audioSource;
    [SerializeField] AudioClip _clip;
    void Start()
    {
        
    }
    
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider near)
    {
        if(near.gameObject.CompareTag("Enemy")) _audioSource.Play();
        _audioSource.pitch = Random.Range(0.9f, 1.2f);
        Debug.Log("asdj");
    }
}
