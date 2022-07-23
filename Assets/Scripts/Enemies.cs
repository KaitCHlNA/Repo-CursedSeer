using UnityEngine;

public class Enemies : MonoBehaviour
{
    enum EnemiesTypes
    {
        Butler,
        Girl,
        Mother,
        Father
    }

    private int enemyDamage;
    private EnemiesTypes _enemiesTypes;

    [SerializeField] private float time;
    private float timeAppear;
    
    void Start()
    {
        
    }

    void Update()
    {
               
        Tempo();
        EnemiesOnGame();
    }
    
    void Tempo()
    {
        time += Time.deltaTime;
        timeAppear = time;
    }

    void EnemiesOnGame()
    {
        switch (_enemiesTypes)
        {
            case EnemiesTypes.Butler:
                enemyDamage = 5;
                //poner instantiate si es posible a los 5 min luego de leer la primera carta
                if (timeAppear == 5f)
                {
                    Debug.Log("butler appears");
                }
                break;
            
            case EnemiesTypes.Girl:
                enemyDamage = 10;
                //instancie a los 10 min o luego de romper el primer artefacto
                if (timeAppear == 10f)
                {
                    Debug.Log("girl appears");
                }
                break;
            
            case EnemiesTypes.Mother:
                enemyDamage = 15;
                //instancie a los 15 min o luego de romper el segundo artefacto
                if (timeAppear == 15f)
                {
                    Debug.Log("mother appears");
                }
                break;
            
            case EnemiesTypes.Father:
                enemyDamage = 20;
                //instancie a los 20 min o luego de romper el tercer artefacto
                if (timeAppear == 20f)
                {
                    Debug.Log("father appears");
                }
                break;
        }
    }

    
}
