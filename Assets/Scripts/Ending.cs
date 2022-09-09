using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ending : MonoBehaviour
{
    [SerializeField] private GameObject textGO;
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private GameObject blackImage;
    [SerializeField] private GameObject madeBy;

    void Start()
    {
        StartCoroutine(EndingDelay());
    }
    
    IEnumerator EndingDelay()
    {
        blackImage.SetActive(true);
        yield return new WaitForSeconds(1.2f);
        _audioSource.Play();
        yield return new WaitForSeconds(6f);
        textGO.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        madeBy.SetActive(true);
        yield return new WaitForSeconds(4f);
        SceneManager.LoadScene(0);
    }
    
}
