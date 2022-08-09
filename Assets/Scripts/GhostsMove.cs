using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostsMove : MonoBehaviour
{
    [SerializeField] private float speed = 0.5f;
    [SerializeField] private float distance = 2f;
    [SerializeField] private Player playerPosition;
    [SerializeField] private Animator anim;

    //agregar booleano para el raycast.
     public static bool beStuned;

    void Start()
    {
        anim = GetComponent<Animator>();
        playerPosition = FindObjectOfType<Player>();
        //beStuned = false;
    }

    void Update()
    {
        
        FollowPlayer();
      /*  if (beStuned)
        {
            FollowPlayer();
        } 
        else if (beStuned == true)
        {
            Stuned();
        }
        */
    }

    void Stuned()
    {
        transform.position = Vector3.Lerp(transform.position, playerPosition.gameObject.transform.position, 0 * Time.deltaTime);
        //transform.LookAt(playerPosition.gameObject.transform);
    }
    void FollowPlayer()
    { 
        transform.LookAt(playerPosition.gameObject.transform);
        transform.position = Vector3.Lerp(transform.position, playerPosition.gameObject.transform.position, speed * Time.deltaTime);
        GhostPlayerDistance();
        GhostAnim();
    }
    void GhostPlayerDistance()
    {
        distance = Vector3.Distance(transform.position, playerPosition.gameObject.transform.position);
        if (distance <= 2)
        {
            speed = 0f;
        }
        else
        {
            speed = 0.1f;
        }
    }
    void GhostAnim()
    {
        if (transform.position != Vector3.zero && distance >= 3)
        {
            anim.SetBool("walking", true);
        }
        else
        {
            anim.SetBool("walking", false);
        }
    }
}
