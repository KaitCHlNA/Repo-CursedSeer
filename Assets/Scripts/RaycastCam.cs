
using System;
using UnityEngine;

public class RaycastCam : MonoBehaviour
{
    [SerializeField] private float rayRange;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, rayRange))
            {
                Debug.Log(hit.collider.name);
            }
            
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawRay(Camera.main.transform.position, Camera.main.transform.forward * rayRange);
    }
}
