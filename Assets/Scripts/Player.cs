using UnityEngine;

public class NewMovePlayer : MonoBehaviour
{
    //Player Movement
    public float moveVelocity = 5f;
    
    //Player Look Rotation
    public float MouseSensibility = 400f;
    public float xRotacion;
    public float yRotacion;
    public Transform cam;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }


    void Update()
    {
        Move();
        //MouseLook();
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

        yRotacion += mouseX;//esto es asi sino funciona al reves
        cam.localRotation= Quaternion.Euler(xRotacion,0,0);
        transform.localRotation = Quaternion.Euler(0,yRotacion,0);


    }
    
}