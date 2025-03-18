using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movementšipky : MonoBehaviour
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
        // Initialize input variables.
        float moveInput = 0f;
        float rotateInput = 0f;

        // Check for up/down arrow keys for forward/backward movement.
        if (Input.GetKey(KeyCode.UpArrow))
        {
            moveInput += 1f;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            moveInput -= 1f;
        }

        // Check for right/left arrow keys for rotation.
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rotateInput += 1f;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rotateInput -= 1f;
        }

        // Move the tank forward/backward.
        Vector2 moveDirection = transform.up * moveInput * moveSpeed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + moveDirection);

        // Rotate the tank.
        float rotation = -rotateInput * rotateSpeed * Time.fixedDeltaTime;
        rb.MoveRotation(rb.rotation + rotation);
    }

}

