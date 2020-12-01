using UnityEngine;

public BasicMovement : MonoBehaviour
{
    public float speed;
    private Rigidbody rb; 

    void Start()
    {
        // Cache.

        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, moveVertical);

        rb.AddForce(movement * speed);

    }

}