
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class LastFollowPlayer : MonoBehaviour
{
    [SerializeField] private GameObject playerPos;
    [SerializeField] private GameObject endMisionTextGO;
    
    [SerializeField] private UnityEvent startingEscape;

    private void Start()
    {
        StartCoroutine(AppearEndingMision());
    }

    private void Update()
    {
        transform.LookAt(playerPos.gameObject.transform);
    }

    IEnumerator AppearEndingMision()
    {
        yield return new WaitForSeconds(3f);
        endMisionTextGO.SetActive(true);
        Destroy(endMisionTextGO.gameObject, 7f);
    }


    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            startingEscape.Invoke();
        }
    }
}
