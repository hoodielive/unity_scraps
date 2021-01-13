using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    public float playerSpeed;
    public float sprintSpeed = 4f;
    public float walkSpeed = 2f;
    public float mouseSensitivity = 2f;
    public float jumpHeight;
    private bool isMoving = false;
    private bool isSprinting = false;
    private float yRot;

    private Animator anim;
    private Rigidbody rigidBody;

    void Start()
    {
        playerSpeed = walkSpeed;
        anim = GetComponent<Animator>();
        rigidBody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        yRot += Input.GetAxis("Mouse X") * mouseSensitivity;
        transform.localEulerAngles = new Vector3(transform.localEulerAngeles.x, yRot, transform.localEulerAngeles.z);

        isMoving = false;

        if (Input.GetAxisRaw("Horizontal") > 0.5f || Input.GetAxis("Horizontal") < -0.5f)
        {
            // transform.Translate(Vector3.right * Input.GetAxis("Horizontal") * playerSpeed);
            rigidbody.velocity += transform.right * Input.GetAxisRaw("Horizontal") * playerSpeed;
            isMoving = true;
        }

        if (Input.GetAxisRaw("Vertical") > 0.5f || Input.GetAxis("Veritical") < -0.5f)
        {
            // transform.Translate(Vector3.forward * Input.GetAxis("Vertical") * playerSpeed);
            rigidbody.velocity += transform.forward * Input.GetAxisRaw("Vertical") * playerSpeed;
            isMoving = true;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.Translate(Vector3.up * jumpHeight);
        }

        if (Input.GetAxisRaw("Sprint") > 0f)
        {
            playerSpeed = sprintSpeed;
            isSprinting = true;
        }
        else if (Input.GetAxis("Sprint") < 1f)
        {
            playerSpeed = walkSpeed;
            isSprinting = false;
        }

        anim.SetBool("isMoving", isMoving);
        anim.SetBool("isSprinting", isSprinting);
    }
}
