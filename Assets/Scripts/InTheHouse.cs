using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InTheHouse : MonoBehaviour
{
    [SerializeField] private AudioClip clipInTheHouse;
    private void OnTriggerEnter(Collider enter)
    {
        if (enter.gameObject.transform.tag == "Player")
        {
            Debug.Log("enter");
            AudioManager.Instance.PlaySound(clipInTheHouse);
            //controlar volume al salir de casa
        }
    }

    private void OnTriggerExit(Collider exit)
    {
        Debug.Log("exit");
    }
}
