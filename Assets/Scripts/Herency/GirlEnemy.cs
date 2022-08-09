using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GirlEnemy : BaseEnemy
{
    void Start()
    {
        BaseEnemy enemy2 = new BaseEnemy();
        //enemy2.name = "Girl";
        enemy2.damage = 1f;
    }

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Player.life -= damage * Time.deltaTime;
        }
    }
}
