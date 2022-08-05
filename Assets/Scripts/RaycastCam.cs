
using System;
using UnityEngine;

public class RaycastCam : MonoBehaviour
{
    [SerializeField] private float rayRange = 9f;
    public GameObject effectPref;
    private GameObject effect;
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, rayRange))
            {
                if (hit.transform.tag == "Enemy")
                {
                    effect = Instantiate(effectPref, hit.point, Quaternion.identity);
                    Destroy(effect, 2f); //lo que dura el stun
                }
            }
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawRay(Camera.main.transform.position, Camera.main.transform.forward * rayRange);
    }
}
