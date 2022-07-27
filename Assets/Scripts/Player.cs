using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    //life
    [SerializeField] float life = 100;
    
    //Player Movement
    public float moveVelocity = 5f;
    
    //Player Look Rotation
    public float MouseSensibility = 400f; 
    float xRotacion; 
    float yRotacion;
    [SerializeField] Transform cam;

    [SerializeField] private AudioClip camSFX;
    [SerializeField] private AudioClip ghostNearSFX;
  
    void Start()
    {
        //Cursor.lockState = CursorLockMode.Locked;
    }
    void Update()
    {
        CamShoot();
        Move();
    }
    void CamShoot()
    {
        if (Input.GetMouseButtonDown(0))
        {
            AudioManager.Instance.PlaySound(camSFX);
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
    }

    //damage
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.transform.tag == "Enemy")
        {
            life -= 0.5f; //personalizar por cada personaje
            Debug.Log("You've been damaged");
            Death();
            AudioManager.Instance.PlaySound(ghostNearSFX);
           
        }
    }
    void Death()
    {
        if (life <= 0)
        {
            SceneManager.LoadScene("Limbo");
        }
    }
    
}