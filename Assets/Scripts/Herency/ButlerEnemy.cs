using System;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class ButlerEnemy : BaseEnemy
{
    public GameObject objWithFatherScript;
    public BaseEnemy go;
    void Start()
    {
        BaseEnemy enemy1 = new BaseEnemy();
        //enemy1.name = "Butler";
        enemy1.damage = 1f;
        
        
        /*
      
        go = FindObjectOfType<BaseEnemy>();
        
        damageVol = objWithFatherScript.GetComponent<PostProcessVolume>();
        damageVol.profile.TryGetSettings(out _chromaticAberration);
         */

    }

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Player.life -= damage * Time.deltaTime;
          //  _chromaticAberration.intensity.value = .4f;
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
