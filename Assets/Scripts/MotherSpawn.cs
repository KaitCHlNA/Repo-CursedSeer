using Unity.VisualScripting;
using UnityEngine;

public class MotherSpawn : MonoBehaviour
{
    [SerializeField] private GameObject motherPref;
    [SerializeField] private Transform spawner;
    [SerializeField] private float time;
    private float timeSpawn;

    private float randomPosition;
    
    void Start()
    {
        //butlerPref.gameObject.name."Mother" = GetComponent<GameObject>();
        //get component del transform.
    }

    void Update()
    {
        Timming();
        SpawnMoment();
    }

    void Timming()
    {
        time += Time.deltaTime;
    }

    void SpawnMoment()
    {
        if (time >= 15)
        {
            Debug.Log("appear");
            randomPosition = Random.Range(0, 20);
            spawner.transform.position = new Vector3(randomPosition, 0, randomPosition);
            //poner el tiempo de spawn, luego de leer la carta
            //poner un destroy cuando se destruya el artefacto
        }
    }
}