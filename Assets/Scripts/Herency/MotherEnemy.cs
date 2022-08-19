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
        enemy3.damage = 3f;
    }

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Player.life -= damage * Time.deltaTime;
          //  _chromaticAberration.intensity.value = .6f;
        }
    }

    private void OnTriggerExit(Collider exit)
    {
        if (exit.CompareTag("Player"))
        {
         //   _chromaticAberration.intensity.value = 0f;
        }
    }
}