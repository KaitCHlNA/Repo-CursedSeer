using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine.UIElements;
using Cursor = UnityEngine.Cursor;
using Random = UnityEngine.Random;
using Range = UnityEngine.SocialPlatforms.Range;


public class Player : MonoBehaviour
{
    //life
    public static float life = 100f;

    //Player Movement
    public float moveVelocity = 5f;
    public float runVelocity = 15f;
    public Rigidbody rb;
    
    //Player Look Rotation
    public float MouseSensibility = 250f;
    float xRotacion; 
    float yRotacion;
    [SerializeField] Transform cam;

    //Sounds
    public AudioSource camShootSound;
    public static bool canShoot;
    
    //Flash effect
    public Animator camAnim;
    
    //Post Processing Effects
    public PostProcessVolume damageVol;
    private Grain _grain;
    private ChromaticAberration _chromaticAberration;
    
    
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        camShootSound = GetComponent<AudioSource>();
        canShoot = true;

        life = 100f;

        //PPE Check
        damageVol.profile.TryGetSettings(out _grain);
        damageVol.profile.TryGetSettings(out _chromaticAberration);
    }
    
    void Update()
    {
        if (canShoot)
        {
            CamShoot();
        }
        Move();
        Death();
    }

    void CamShoot()
    {
        if (Input.GetMouseButtonDown(0))
        {
            camAnim.SetBool("clickOnCam", true);
            camShootSound.Play();
            camShootSound.pitch = Random.Range(.9f, 1.1f);
        }

        if (Input.GetMouseButtonUp(0))
        {
            camAnim.SetBool("clickOnCam", false);
            //canShoot = false;
        }
    }
    void Move()
    {
        Vector3 hor = Input.GetAxis("Horizontal") * transform.right;
        Vector3 ver = Input.GetAxis("Vertical") * transform.forward;
        
        float mouseX = Input.GetAxis("Mouse X") * MouseSensibility * Time.deltaTime; 
        float mouseY = Input.GetAxis("Mouse Y") * MouseSensibility * Time.deltaTime;
       
       var y = rb.velocity.y;
       rb.velocity = (hor + ver).normalized * moveVelocity;
       rb.velocity = new Vector3(rb.velocity.x, y, rb.velocity.z);
       
        xRotacion -= mouseY;
        xRotacion = Mathf.Clamp(xRotacion, -70,70);

        yRotacion += mouseX;
        cam.localRotation= Quaternion.Euler(xRotacion,0,0);
        transform.localRotation = Quaternion.Euler(0,yRotacion,0);
        
        
        //RUN
        if (Input.GetKey(KeyCode.LeftShift))
        {
            y = rb.velocity.y;
           rb.velocity = (hor + ver).normalized * runVelocity;
           rb.velocity = new Vector3(rb.velocity.x, y, rb.velocity.z);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
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