using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ObjectsEvents : MonoBehaviour
{
    [SerializeField] private GameObject dollThings;
    [SerializeField] private GameObject safeText;
    [SerializeField] private GameObject haloPartEffect;

    public void DesactiveDollThings()
    {
        dollThings.SetActive(false);
        print("Destroying doll things - " + this);
    }

    public void ShowSafeMessage()
    {
        safeText.SetActive(true);
        Destroy(safeText.gameObject, 3f);
        print("Being Safe - " + this);
    }

    public void InstantiateHaloLight()
    {
        Instantiate(haloPartEffect, transform.position, transform.rotation);
        print("Instantiation of a Halo Light - " + this);
    }
}
