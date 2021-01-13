using UnityEngine;
using System.Collections;

public class CompletePlayerController : MonoBehaviour
{
    public float speed; // Floating point variable to store the player's movement speed.
    private Rigidbody2D rb2d; // Store a reference to the Rigidbody2D component required to use 2D physics.

    void Start()
    {
        // Get and store a reference to the Rigidbody2D component so that we can access it.
        rb2d = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate() // Best for Physics code because its called at a fixed interval idependent of frame rate.
    {
        // Store the current horizontal input in the float moveHorizontal.
        float moveHorizontal = Input.GetAxis("Horizontal");

        // Store the current vertical input in the float moveVertical.
        float moveVertical = Input.GetAxis("Vertical");

        // Use the two store floats to create a new Vector2 variable movement.
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);

        // Call the AddForce function to our RigidBody2D rb2d supplying movement supplying movement multiplied by speed to
        // move our player.
        rb2d.AddForce(movement * speed);
    }
}
