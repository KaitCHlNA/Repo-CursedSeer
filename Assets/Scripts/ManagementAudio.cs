using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagementAudio : MonoBehaviour
{
    private AudioSource startingGameCar;
    private AudioSource endingGameCar;
    private AudioSource limboState;
    private AudioSource background;
    private AudioSource house;
    private AudioSource enemyOneAppear;
    private AudioSource enemyTwoAppear;
    private AudioSource enemyThreeAppear;
    private AudioSource enemyFourAppear;
    private AudioSource enemyNear;
    private AudioSource camShoot;
    
    
    void Awake()
    {
        //DontDestroyOnLoad();
    }
    void Start()
    {
        
    }
    void Update()
    {
        
    }

    
    //para bajar el volume de background
    void OnTriggerEnter(Collider enterHouse)
    {
        if (enterHouse.transform.gameObject.tag == "Player")
        {
            house.volume = 0.4f;
            background.volume = 0.1f;
            Debug.Log("entraste a casa");

        }
    }

    //para subir el volume de background
    void OnTriggerExit(Collider exitHouse)
    {
        if (exitHouse.transform.gameObject.name == "Exit")
        {
            house.volume = 0.1f;
            background.volume = 0.4f;
            Debug.Log("saliste de casa");
        }
    }
    
    //Para cuando el fantasma esté cerca y quitando vida

    private void OnCollisionStay(Collision near)
    {
        if (near.transform.gameObject.tag == "Player")
        {
            enemyNear.Play();
        }
    }
}
