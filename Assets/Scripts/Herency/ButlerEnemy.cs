using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ButlerEnemy : BaseEnemy
{
    void Start()
    {
        BaseEnemy enemy1 = new BaseEnemy();
        //enemy1.name = "Butler";
        enemy1.damage = .5f;
    }

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Player.life -= damage * Time.deltaTime;
        }
    }
}
