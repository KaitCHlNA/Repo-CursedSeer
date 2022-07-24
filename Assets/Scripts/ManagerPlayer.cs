using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagerPlayer : MonoBehaviour
{
    [SerializeField] float life = 100;
    
   
    void Update()
    {
        Death();
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.transform.tag == "Enemy")
        {
            life -= 0.5f;
            Debug.Log("You've been damaged");
        }
            
        //personalizar por cada personaje
    }

    void Death()
    {
        if (life <= 0)
        {
            Debug.Log("Game Over");
            SceneManager.LoadScene("Limbo");

        }
    }
}
