using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ArtefactsManager : MonoBehaviour
{
    public GameObject[] spawnArtefacts;

   public enum Artefacts
    {
        leopard,
        teddy,
        gramophone,
        shoes
    }

    public Artefacts _artefacts;

    private float currentTime;
    //private int numberOfPrefabsArtef = 4;
    
    
    void Start()
    {
        spawnArtefacts[0].SetActive(false);
        spawnArtefacts[1].SetActive(false);
        spawnArtefacts[2].SetActive(false);
        spawnArtefacts[3].SetActive(false);
       
      
    }
    
    void Update()
    {
        currentTime += Time.deltaTime;
        //Debug.Log(time);
        Timer();
        Spawn();
        
    }
    
    

    void Timer()
    {
        if (currentTime >= 5)
        {
            _artefacts = Artefacts.leopard;
        }
        
        if (currentTime >= 10)
        {
            _artefacts = Artefacts.teddy;
        }
        
        if (currentTime >= 15)
        {
            _artefacts = Artefacts.gramophone;
        }
        
        if (currentTime >= 20)
        {
            _artefacts = Artefacts.shoes;
        }
    }

    void Spawn()
    {
      switch (_artefacts)
      {
          case Artefacts.leopard:
              if (currentTime >= 5)
              {
                  spawnArtefacts[0].SetActive(true);
                  spawnArtefacts[1].SetActive(false);
                  spawnArtefacts[2].SetActive(false);
                  spawnArtefacts[3].SetActive(false);
              }

              break;

          case Artefacts.teddy:
              if(currentTime >= 10)
              {
                  spawnArtefacts[0].SetActive(false);
                  spawnArtefacts[1].SetActive(true);
                  spawnArtefacts[2].SetActive(false);
                  spawnArtefacts[3].SetActive(false);
              }

              break;
          
          case Artefacts.gramophone:
              if(currentTime >= 15)
              {
                  spawnArtefacts[0].SetActive(false);
                  spawnArtefacts[1].SetActive(false);
                  spawnArtefacts[2].SetActive(true);
                  spawnArtefacts[3].SetActive(false);
              }

              break;
          
          case Artefacts.shoes:
              if(currentTime >= 20)
              {
                  spawnArtefacts[0].SetActive(false);
                  spawnArtefacts[1].SetActive(false);
                  spawnArtefacts[2].SetActive(false);
                  spawnArtefacts[3].SetActive(true);
              }

              break;
              
      }
    }
}
