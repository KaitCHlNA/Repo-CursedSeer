using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArtefactSpawn : MonoBehaviour
{
    enum Artefacts
    {
        leopard,
        teddy,
        gramophone,
        shoes
    }

    private Artefacts _artefacts;

    [SerializeField] Transform leopardSpawn;
    [SerializeField] GameObject leopardPrefab;
    
    [SerializeField] Transform teddySpawn;
    [SerializeField] GameObject teddyPrefab;
    
    [SerializeField] Transform gramophoneSpawn;
    [SerializeField] GameObject gramophonePrefab;
    
    [SerializeField] Transform shoesSpawn;
    [SerializeField] GameObject shoesPrefab;

    private float time;

    void Start()
    {
        
    }
    
    void Update()
    {
        time += Time.deltaTime;
        //spawnear 1 solo artefacto en 1 tiempo determinado?
    }

    void SpawnerArtefacts()
    {
        switch (_artefacts)
        {
            case Artefacts.leopard:
                //aparezca al ver la carta
                Instantiate(leopardPrefab.gameObject, leopardSpawn.position, transform.rotation);
                //agregar el destruir luego de un click
                break;
            case Artefacts.teddy:
                if(time >= 5f) //aparezca al ver la carta o al pasar 5 min
                    Instantiate(teddyPrefab.gameObject, teddySpawn.position, transform.rotation);
                //agregar el destruir luego de un click
                break;
            case Artefacts.gramophone:
                if(time >= 10f) //aparezca al ver la carta o al pasar 10 min
                    Instantiate(gramophonePrefab.gameObject, gramophoneSpawn.position, transform.rotation);
                //agregar el destruir luego de un click
                break;
            case Artefacts.shoes:
                if(time >= 15f) //aparezca al ver la carta o al pasar 15 min
                    Instantiate(shoesPrefab.gameObject, shoesSpawn.position, transform.rotation);
                //agregar el destruir luego de un click
                break;

        }
    }
}
