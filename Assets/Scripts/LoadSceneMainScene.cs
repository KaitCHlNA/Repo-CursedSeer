using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneMainScene : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    [SerializeField] private float transitionTime;
    [SerializeField] AudioSource _audioSource;
    [SerializeField] GameObject managerUI;
    
    public void LoadNextScene()
    {
        int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
        StartCoroutine(SceneLoad(nextSceneIndex));
        _audioSource.Play();
        managerUI.SetActive(true);
        
    }
    
    public IEnumerator SceneLoad(int sceneIndex)
    {
        _animator.SetTrigger("StartGame");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(sceneIndex);
    }
}
