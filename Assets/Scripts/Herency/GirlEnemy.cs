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
        enemy2.damage = 2f;
    }

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Player.life -= damage * Time.deltaTime;
          //  _chromaticAberration.intensity.value = .5f;
        }
    }

    private void OnTriggerExit(Collider exit)
    {
        if (exit.CompareTag("Player"))
        {
          //  _chromaticAberration.intensity.value = 0f;
        }
    }
}
