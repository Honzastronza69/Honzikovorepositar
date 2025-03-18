using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementWASD : MonoBehaviour
{
    public float moveSpeed = 10f; 
    public float rotateSpeed = 10f; 

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float moveInput = 0f;
        float rotateInput = 0f;

        if (Input.GetKey(KeyCode.W))
        {
            moveInput += 1f;
        }
        if (Input.GetKey(KeyCode.S))
        {
            moveInput -= 1f;
        }

        if (Input.GetKey(KeyCode.D))
        {
            rotateInput += 1f;
        }
        if (Input.GetKey(KeyCode.A))
        {
            rotateInput -= 1f;
        }

        // pohyb tanku dopøedu a dozádu
        Vector2 moveDirection = transform.up * moveInput * moveSpeed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + moveDirection);

        // Rotace tankiu
        float rotation = -rotateInput * rotateSpeed * Time.fixedDeltaTime;
        rb.MoveRotation(rb.rotation + rotation);
    }

}