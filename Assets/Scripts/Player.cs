using UnityEngine;

public class Player : MonoBehaviour
{
    private float hor;
    private float ver;
    private float moveSpeed = 5f;
    private float runSpeed = 10f;
    private float turnSpeed = 250f;
    private Vector3 inputPlayer;
    private Vector3 turnPlayer;
    private Rigidbody rb;
    private Animator anim;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        Movement();
    }

    void Movement()
    {
        ver = Input.GetAxis("Vertical");
        hor = Input.GetAxis("Horizontal");

        inputPlayer = new Vector3(0, 0, ver);
        turnPlayer = new Vector3(0, hor, 0);

        //rb.AddForce(inputPlayer * moveSpeed);
        transform.Translate(inputPlayer * moveSpeed * Time.deltaTime);
        transform.Rotate(turnPlayer * turnSpeed * Time.deltaTime);

        if (inputPlayer != Vector3.zero)
        {
            anim.SetBool("isWalking", true);
        }
        else
        {
            anim.SetBool("isWalking", false);
        }
        
        float run = Input.GetAxis("Run");
        
        if (run > 0)
        {
            transform.Translate(inputPlayer * runSpeed * Time.deltaTime);
        }
    }

    

}
