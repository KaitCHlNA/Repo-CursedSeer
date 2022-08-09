
using System;
using Unity.VisualScripting;
using UnityEngine;

public class RaycastCam : MonoBehaviour
{
    [SerializeField] private float rayRange = 9f;
    public GameObject effectPref;
    private GameObject effect;
    private bool particleEffect;

    void Start()
    {
        //particleEffect = false;
    }
    
    void Update()
    {
       // StunedDuration();
        
        if(Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            if(Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, rayRange))
            {
                if(hit.transform.tag == "Enemy")
                {
                    //particleEffect = true;
                    effect = Instantiate(effectPref, hit.point, Quaternion.identity);
                    Destroy(effect, 2f);
                }
            }
        }
    }
/*
    void StunedDuration()
    {
        if(particleEffect)
        {
            GhostsMove.beStuned = false;
        }
        else
        {
            GhostsMove.beStuned = true;
        }
    }
*/
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawRay(Camera.main.transform.position, Camera.main.transform.forward * rayRange);
    }
}
