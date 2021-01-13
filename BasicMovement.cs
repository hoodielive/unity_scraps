using System;
using UnityEngine;

public BasicMovement : MonoBehaviour
{
    public float speed;
    private Rigidbody rb; 
    public Animator animator;

    void Start()
    {
        // Cache.
        rb = GetComponent<Rigidbody2D>();
        animator.
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal * Time.deltaTime, moveVertical);

        rb.AddForce(movement * speed);

    }
}
