using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;


public class PlayerUnityEvent : MonoBehaviour
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
  
    void Start()
    {
        //Cursor.lockState = CursorLockMode.Locked;
        shootSound = true;
        flashActive = false;
    }
    void Update()
    {
        CamShoot();
        Move();
        Death();
        
        if (flashActive == true)
        {
            flashActive = false;
        } //fix to flash again
    }
    void CamShoot()
    {
        if (Input.GetMouseButtonDown(0))
        {
            camAnim.SetBool("ClickOnCam", true);
            ASPlayer.clip = camSFX;
            ASPlayer.Play();
        }
    }  //fix flash per click
    
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
        }
    } //sonido de ser dañado
    void Death()
    {
        if (life <= 0)
        {
            SceneManager.LoadScene(2);
        }
    }
}