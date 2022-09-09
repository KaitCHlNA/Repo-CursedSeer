using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMisionText : MonoBehaviour
{
    [SerializeField] private GameObject startMisionTextGO;
    void Start()
    {
        StartCoroutine(TimeToAppearText());
    }

    IEnumerator TimeToAppearText()
    {
        yield return new WaitForSeconds(6f);
        startMisionTextGO.SetActive(true);
        Destroy(startMisionTextGO.gameObject, 7f);
        
    }
}
