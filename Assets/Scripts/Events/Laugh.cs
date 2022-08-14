using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laugh : MonoBehaviour
{
    public AudioSource audLaugh;
    void Start()
    {
        Events.testEvent += EvilLaughActive;
        Events.testEventTwo += StopLaugh;
    }
    
    void EvilLaughActive()
    {
        audLaugh.Play();
        print("A sound appeared, press right click to mute the sound - " + this);
    }

    void StopLaugh()
    {
        audLaugh.volume = 0f;
        print("A sound 'Dissapeared' walk to the cube - " + this);
    }
    
    void OnDisable()
    {
        Events.testEvent -= EvilLaughActive;
        Events.testEventTwo -= EvilLaughActive;
        print(this);
    }
}
