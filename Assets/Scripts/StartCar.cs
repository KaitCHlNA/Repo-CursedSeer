using UnityEngine;

public class StartCar : MonoBehaviour
{
    [SerializeField] AudioSource _audioSource;
    [SerializeField] AudioClip _clip;

    private void Update()
    {
        _audioSource.Play();
        Destroy(this,5f);
    }

}
