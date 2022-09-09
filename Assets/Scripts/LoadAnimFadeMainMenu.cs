using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadAnimFadeMainMenu : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    [SerializeField] private float transitionTime;

    //[SerializeField] AudioSource _audioSource;
    [SerializeField] private GameObject _gameObjectText;
    public void LoadNextScene()
    {
        int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
        StartCoroutine(SceneLoad(nextSceneIndex));
    }
    
    public IEnumerator SceneLoad(int sceneIndex)
    {
        _animator.SetTrigger("StartTransition");
        _gameObjectText.SetActive(true);
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(sceneIndex);
    }
}
