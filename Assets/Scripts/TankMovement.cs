using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMovement : MonoBehaviour
{
    public float moveSpeed = 10f; // Speed of forward/backward movement
    public float rotateSpeed = 10f; // Speed of rotation

    private Rigidbody2D rb; // Reference to the Rigidbody2D

    void Start()
    {
        // Get the Rigidbody2D component attached to the tank
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        // Get input for movement and rotation
        float moveInput = Input.GetAxis("Vertical"); // Forward/backward input
        float rotateInput = Input.GetAxis("Horizontal"); // Left/right input

        // Move the tank forward/backward
        Vector2 moveDirection = transform.up * moveInput * moveSpeed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + moveDirection);

        // Rotate the tank
        float rotation = -rotateInput * rotateSpeed * Time.fixedDeltaTime;
        rb.MoveRotation(rb.rotation + rotation);
    }
}