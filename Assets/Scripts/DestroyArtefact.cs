using System;
using System.Collections;
using System.Collections.Generic;
using System.IO.Compression;
using UnityEngine;
using UnityEngine.UI;

public class DestroyArtefact : MonoBehaviour
{
    private bool canCount;
    public float destroyTime;
    public float counter;

    public AudioSource _Audio;

    public GameObject thisGo;
    public GameObject nextGo;

    public GameObject barUIGO;
    public Image artBar;
    public float artefactLife;
    //private float maxArtLife = 100f;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            canCount = true;
            barUIGO.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            canCount = false;
            counter = 0;
            barUIGO.SetActive(false);
        }
    }
    

    void Update()
    {
        if (canCount)
        {
            AppearLifeArtBar();
            
            if (Input.GetKey(KeyCode.E))
            {
                counter += Time.deltaTime;
                
                if (counter >= destroyTime)
                {
                    DestroyArt();
                }
            } else if (Input.GetKeyUp(KeyCode.E))
            {
                counter = 0f;
            }

        }
    }

    void DestroyArt()
    {
        nextGo.SetActive(true);
        thisGo.SetActive(false);
        _Audio.Play();
    }

    void AppearLifeArtBar()
    {
        artBar.fillAmount = 1 - (counter / destroyTime);
    }
}
