using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Rendering.PostProcessing;


public class Player : MonoBehaviour
{
    //life
    public static float life = 100f;

    //Player Movement
    public float moveVelocity = 5f;
    public float runVelocity = 15f;
    
    //Player Look Rotation
    public float MouseSensibility = 400f; 
    float xRotacion; 
    float yRotacion;
    [SerializeField] Transform cam;

    //Sounds
    [SerializeField] private AudioSource ASPlayer;
    [SerializeField] private AudioClip camSFX;
    [SerializeField] private AudioClip ghostNearSFX;
    public static bool shootSound;
   
    //Flash effect
    public bool flashActive;
    public Animator camAnim;
    
    //Post Processing Effects
    public PostProcessVolume damageVol;
    private Grain _grain;
    private ChromaticAberration _chromaticAberration;

    [SerializeField] private Light luzTest;
  
    void Start()
    {
        //Cursor.lockState = CursorLockMode.Locked;
        shootSound = true;
        flashActive = false;
        
        //PPE Check
        damageVol.profile.TryGetSettings(out _grain);
        damageVol.profile.TryGetSettings(out _chromaticAberration);
        
    }
    void Update()
    {
        CamShoot();
        Move();
        Death();
        /*
        if (flashActive == true)
        {
            flashActive = false;
        } 
        */
    }
    void CamShoot()
    {
        if (Input.GetMouseButtonDown(0))
        {
           // camAnim.SetBool("clickOnCam", true);
           luzTest.intensity = 1000;
            ASPlayer.clip = camSFX;
            ASPlayer.Play();
        }

        if (Input.GetMouseButtonUp(0))
        {
           // camAnim.SetBool("clickOnCam", false);
            luzTest.intensity = 0;
        }
    }
    void Move()
    {
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");

        float mouseX = Input.GetAxis("Mouse X") * MouseSensibility * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * MouseSensibility * Time.deltaTime;

        transform.Translate(new Vector3(hor,0,ver) * moveVelocity * Time.deltaTime);

        xRotacion -= mouseY;
        xRotacion = Mathf.Clamp(xRotacion, -70,70);

        yRotacion += mouseX;
        cam.localRotation= Quaternion.Euler(xRotacion,0,0);
        transform.localRotation = Quaternion.Euler(0,yRotacion,0);

        if (Input.GetKey(KeyCode.LeftShift))
        {
            transform.Translate(new Vector3(hor,0,ver) * runVelocity * Time.deltaTime);
        }
    }
    
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            ASPlayer.clip = ghostNearSFX;
            ASPlayer.Play();
            _grain.intensity.value = .9f;
        }
    }
    private void OnTriggerExit(Collider exit)
    {
        if (exit.CompareTag("Enemy"))
        {
            _grain.intensity.value = 0f;
        }
    }

    void Death()
    {
        if (life <= 0)
        {
            SceneManager.LoadScene(2);
        }
    }
}