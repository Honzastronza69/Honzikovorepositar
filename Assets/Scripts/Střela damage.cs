using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int damage = 1; // Damage to tanks

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Wall")) // Check if it hits a wall
        {
            Destroy(gameObject); // Destroy bullet on impact with the wall
        }

        TankHealth tank = other.GetComponent<TankHealth>();
        if (tank != null)
        {
            tank.TakeDamage(damage);
            Destroy(gameObject); // Destroy bullet after hitting a tank
        }
    }
}