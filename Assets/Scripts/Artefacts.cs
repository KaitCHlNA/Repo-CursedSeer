using System.Timers;
using UnityEngine;

public class Artefacts : MonoBehaviour
{
    //1° Enemy
   [SerializeField] private GameObject leopardPref;
   [SerializeField]  private Transform leopardSpawn;
    
   [SerializeField]  private GameObject butlerPref;
   [SerializeField]  private Transform butlerSpawn;
    
    //2° Enemy
    [SerializeField]  private GameObject teddyPref;
    [SerializeField]  private Transform teddySpawn;
    
    [SerializeField]  private GameObject girlPref;
    [SerializeField]  private Transform girlSpawn;

    //3° Enemy
    [SerializeField]  private GameObject gramophPref;
    [SerializeField]  private Transform gramophSpwan;
    
    [SerializeField]   private GameObject motherPref;
    [SerializeField]  private Transform motherSpawn;
    
    //4° Enemy
    [SerializeField]  private GameObject shoesPref;
    [SerializeField]  private Transform shoesSpawn;
    
    [SerializeField]   private GameObject fatherPref;
    [SerializeField]  private Transform fatherSpawn;

    private float time;
    private float searchingTime;
    private float endTime;

    private int numRandom;

    private Player playerPosition;
    
    void Start()
    {
        
    }
    
    void Update()
    {
        //EnemiesSpawn();
    }
    
    void EnemiesSpawn()
    {
        time += Time.deltaTime;

        if (time >= 5)
        {
            Instantiate(butlerPref, butlerSpawn.position, butlerSpawn.rotation);
            Debug.Log("butler spawn");
        }
        else if (time >= 10)
        {
            Instantiate(girlPref, girlSpawn.position, girlSpawn.rotation);
            Debug.Log("girl spawn");
        }
        else if (time >= 15)
        {
            Instantiate(motherPref, motherSpawn.position, motherSpawn.rotation);
            Debug.Log("mother spawn");
        }
        else if(time >= 20)
        {
            Instantiate(fatherPref, fatherSpawn.position, fatherSpawn.rotation);
            Debug.Log("father spawn");
        }
    }
    
    void ArtefactSpawn()
    {
        
        
    }
}
