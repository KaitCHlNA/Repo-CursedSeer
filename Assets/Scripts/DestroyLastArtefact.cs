using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyLastArtefact : MonoBehaviour
{
    private bool canCount;
    public float destroyTime;
    private float counter;

    public AudioSource _Audio;

    public GameObject thisGo;
    public GameObject goWithSoundAndEffect;
    
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
                _Audio.Stop();
                
            } else if (Input.GetKeyDown(KeyCode.E))
            {
                _Audio.Play();
            } 
            
        }
    }

    void DestroyArt()
    {
        goWithSoundAndEffect.SetActive(true);
        thisGo.SetActive(false);
        
    }
    
    void AppearLifeArtBar()
    {
        artefactLife = counter;
        artBar.fillAmount = 1 - (counter / destroyTime);
    }
}
