using UnityEngine;

public class Player : MonoBehaviour
{
    private float hor;
    private float ver;
    private float moveSpeed = 3f;
    private float runSpeed = 10f;
    private float turnSpeed = 250f;
    private float mouseSensibility = 150f;
    private float xRotation;
    private float yRotation;
    public Transform cam;
    private Vector3 inputPlayer;
    private Rigidbody rb;
   
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    void FixedUpdate()
    {
        Movement();
        MouseCam();
    }

    void Movement()
    {
        ver = Input.GetAxis("Vertical");
        hor = Input.GetAxis("Horizontal");

        //inputPlayer = new Vector3(hor, 0, ver);

        //rb.velocity = inputPlayer;
        //transform.Translate(inputPlayer * moveSpeed * Time.deltaTime);

        Vector3 inputPlayerTwo = new Vector3(0, 0, ver);
        
        transform.Rotate(new Vector3(0, hor, 0) * turnSpeed * Time.deltaTime); 
        transform.Translate(inputPlayerTwo * moveSpeed * Time.deltaTime);
        
        
        
        float run = Input.GetAxis("Run");
        
        if (run > 0)
        {
            //rb.AddForce(inputPlayerTwo * runSpeed);
            transform.Translate(inputPlayerTwo * runSpeed * Time.deltaTime);
        }
        
    }

    void MouseCam()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensibility * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensibility * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -70,70);

        yRotation += mouseX;
        cam.localRotation= Quaternion.Euler(xRotation,yRotation,0);
    }

}
