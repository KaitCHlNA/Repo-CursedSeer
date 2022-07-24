using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class ToReadTheLetter : MonoBehaviour
{
    [SerializeField] AudioSource _audioSource;
    [SerializeField] AudioClip _clip;

    void Start()
    {
        //obtener componente del efecto de sonido
    }
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider reading)
    {
        if(reading.gameObject.CompareTag("Player")) _audioSource.Play();
        _audioSource.pitch = Random.Range(0.8f,1.2f);
    }
}
