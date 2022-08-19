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
        enemy4.damage = 4f;
    }

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Player.life -= damage * Time.deltaTime;
          //  _chromaticAberration.intensity.value = .8f;
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
