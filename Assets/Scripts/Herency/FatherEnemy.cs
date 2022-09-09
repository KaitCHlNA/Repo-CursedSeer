using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class FatherEnemy : BaseEnemy
{
    void Start()
    {
        damage = 40f;
        
        GameObject go = GameObject.Find("PPE PlayerDamage");
        damageVolume = go.GetComponent<PostProcessVolume>(); 
        
        GetCompSettings();
    }

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Player.life -= damage * Time.deltaTime; 
            _chromaticAberration.intensity.value = .8f;
        }
    }

    private void OnTriggerExit(Collider exit)
    {
        if (exit.CompareTag("Player"))
        {
           _chromaticAberration.intensity.value = 0f;
        }
    }
}
