using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FatherEnemy : BaseEnemy
{
    void Start()
    {
        BaseEnemy enemy4 = new BaseEnemy();
        //enemy4.name = "Father";
        enemy4.damage = 2f;
    }

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Player.life -= damage * Time.deltaTime;
        }
    }
}
