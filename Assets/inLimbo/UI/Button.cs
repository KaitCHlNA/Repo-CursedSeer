using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public void ChangeScene()
    {
        StartCoroutine(DelayRetry());
    }

    IEnumerator DelayRetry()
    {
        yield return new WaitForSeconds(1.5f);
        
        SceneManager.LoadScene(1);
    }
}


