using System;
using UnityEngine;
using Random = System.Random;
using System.Collections;

public class AudioManager : MonoBehaviour
{
  [SerializeField] private AudioSource camSound,ghostNearSound, inTheHouseSound;

  //[SerializeField] private AudioClip clipCarDoorOpen, clipBackground;
   
  public static AudioManager Instance { get; private set; }

  private void Awake()
  {
    if (Instance != null && Instance != this)
    {
      Destroy(this);
    }
    else
    {
        Instance = this; 
        DontDestroyOnLoad(this);
    }
  }
 
  public void PlaySound(AudioClip clip)
  {
    //camera
    camSound.PlayOneShot(clip);
    camSound.pitch = UnityEngine.Random.Range(0.9f, 1.1f);
    
    //Ghost Near
    ghostNearSound.PlayOneShot(clip);
    //ghostNearSound.pitch = UnityEngine.Random.Range(1f, 1.5f);
    
    //in the House
    //inTheHouseSound.PlayOneShot(clip);
    
  }
}
