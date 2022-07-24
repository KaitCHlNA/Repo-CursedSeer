using Unity.VisualScripting;
using UnityEngine;

public class ButlerSpawn : MonoBehaviour
{
    [SerializeField] private GameObject butlerPref;
    [SerializeField] private float time;
    private float timeSpawn;

    private ButlerSpot _butlerSpot;
    
    
    void Start()
    {
        //butlerPref.gameObject.name."Butler" = GetComponent<GameObject>();
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
        if (time >= 5f)
        {
            Instantiate(butlerPref, _butlerSpot.transform.position,transform.rotation);
            Debug.Log("appear");
            //poner el tiempo de spawn, luego de leer la carta
            //poner un destroy cuando se destruya el artefacto
        }
    }
}
