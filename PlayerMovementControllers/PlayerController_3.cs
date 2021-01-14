using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public RigidBody2D starBody; 
    public float speed;

    void Update()
    {
        starBody.velocity() = new Vector2(Input.GetAxisRaw("Horizontal") * speed, Input.GetAxisRaw("Vertical") * 2);
    }
}
