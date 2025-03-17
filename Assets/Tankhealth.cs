using UnityEngine;

public class TankHealth : MonoBehaviour
{
    public int health = 3;
    public GameObject VýbuchPrefab; // Assign explosion prefab in Inspector

    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        if (VýbuchPrefab != null)
        {
            Instantiate(VýbuchPrefab, transform.position, Quaternion.identity);
        }
        Destroy(gameObject); // Destroy the tank
    }
}