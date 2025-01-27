using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController : MonoBehaviour
{
    public GameObject projectilePrefab; // Assign your projectile prefab in the Inspector
    public Transform firePoint;        // Assign the fire point in the Inspector
    public float projectileSpeed = 10f;

    void Update()
    {
        // Check for the fire input (e.g., left mouse button or space bar)
        if (Input.GetButtonDown("Fire1"))
        {
            FireProjectile();
        }
    }

    void FireProjectile()
    {
        // Instantiate the projectile at the fire point's position and rotation
        GameObject projectile = Instantiate(projectilePrefab, firePoint.position, firePoint.rotation);

        // Get the Rigidbody2D component of the projectile
        Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();

        // Set the velocity of the projectile in the direction of the fire point's up vector
        rb.velocity = firePoint.up * projectileSpeed;
    }
}

