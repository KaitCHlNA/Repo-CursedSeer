using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class EnemiesMove : MonoBehaviour
{
    enum Enemies
    {
        butler,
        girl,
        mother,
        father
    }

    private Enemies _enemies;
    private int damage;

    private Animator anim;
    
    [SerializeField] private Player playerPosition;
    private float speed = 0.1f;
    private float distance = 2f;

    private float time;
    private float timeToAppear;

    void Start()
    {
        anim = GetComponent<Animator>();
        playerPosition = FindObjectOfType<Player>();
    }

    
    void Update()
    {
        EnemyOnGame();
    }
    void EnemyOnGame()
    {
        switch (_enemies)
        {
            case Enemies.butler:
                Following();
                //EnemyStuned();
                damage = 5;
                break;
            
            case Enemies.girl:
                Following();
                //EnemyStuned();
                damage = 10;
                break;
            
            case Enemies.mother:
                Following();
                //EnemyStuned();
                damage = 15;
                break;
            
            case Enemies.father:
                Following();
                //EnemyStuned();
                damage = 20;
                break;
        }
    }
   /* void EnemyStuned()
    {
        if (RaycastCam.effectActive == false)
        {
            Following();
        } 
        else if (RaycastCam.effectActive == true)
        {
            //transform.LookAt(playerPosition.gameObject.transform);
            transform.position = Vector3.zero;
        }
    }
    */
    void Following()
    {
        transform.LookAt(playerPosition.gameObject.transform);
        transform.position = Vector3.Lerp(transform.position, playerPosition.gameObject.transform.position, speed * Time.deltaTime);

        EnemyPlayerDistance();
        Anim();
    }

    void EnemyPlayerDistance()
    {
        distance = Vector3.Distance(transform.position, playerPosition.gameObject.transform.position);
        if (distance <= 3)
        {
            speed = 0f;
        }
        else
        {
            speed = 0.1f;
        }
    }
    void Anim()
    {
        if (transform.position != Vector3.zero && distance >= 6 )
        {
            anim.SetBool("walking", true);
        }
        else 
        {
            anim.SetBool("walking", false);
        }
    }

    //Agregar void para dejar de moverse por cierto tiempo en caso de ser stuneados por la cámara
}
