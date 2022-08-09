using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MotherEnemy : BaseEnemy
{
    void Start()
    {
        BaseEnemy enemy3 = new BaseEnemy();
        //enemy3.name = "Mother";
        enemy3.damage = 1.5f;
    }

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Player.life -= damage * Time.deltaTime;
        }
    }
}
