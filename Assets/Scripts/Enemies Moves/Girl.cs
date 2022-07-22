using Cinemachine;
using UnityEngine;

public class Girl : MonoBehaviour
{
    private Animator anim;

    [SerializeField] private Transform playerPosition;
    private float speed = 0.1f;
    private float distance = 2f;

    //private Player _player;

    void Start()
    {
        anim = GetComponent<Animator>();
        //playerPosition._player = GetComponent<Transform>();
    }


    void Update()
    {
        Following();
    }

    void Following()
    {
        transform.LookAt(playerPosition);
        transform.position = Vector3.Lerp(transform.position, playerPosition.position, speed * Time.deltaTime);

        EnemyPlayerDistance();
        GirlAnim();
    }

    void EnemyPlayerDistance()
    {
        distance = Vector3.Distance(transform.position, playerPosition.position);
        if (distance <= 6)
        {
            speed = 0f;
        }
        else
        {
            speed = 0.1f;
        }
    }

    void GirlAnim()
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
}