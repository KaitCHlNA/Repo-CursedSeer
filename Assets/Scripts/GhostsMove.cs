using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostsMove : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float distance;
    [SerializeField] private Player playerPosition;
    [SerializeField] private Animator anim;
    
     public bool beStuned;
     public bool followPlayer;

    void Start()
    {
        anim = GetComponent<Animator>();
        playerPosition = FindObjectOfType<Player>();
        
    }

    void Update()
    {
        if (beStuned == false)
        {
            FollowPlayer();
        } 
        else if (beStuned == true)
        {
            Stuned();
        }
       
    }

    void Stuned()
    {
        Invoke("StopStuned", 2f);
        anim.SetBool("walking", false);
    }
    
    void StopStuned()
    {
        beStuned = false;
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
        if (distance <= 2f)
        {
            speed = 0f;
        }
        else
        {
            speed = .8f;
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
