using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLogic : MonoBehaviour
{
    CharacterController m_characterController;
    float m_movementSpeed = 5.0f;
    float m_horizontalInput;
    float m_verticalInput;

    Vector3 m_movement;

    private void Start()
    {
        m_characterController = GetComponent<CharacterController>();
    }

    private void Update()
    {
        m_horizontalInput = Input.GetAxis("Horizontal");
        m_verticalInput = Input.GetQAxis("Vertical");
    }

    private void FixedUpdate()
    {
        m_movement.x = m_horizontalInput * m_movementSpeed * Time.deltaTime;
        
        if (m_characterController)
        {
            m_characterController.Move(m_movement)
        }
    }
}
