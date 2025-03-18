using UnityEngine;

public class TankHealth : MonoBehaviour
{
    public int health = 3; //tank má 3 hp

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
        Destroy(gameObject); //znièit tank
    }
}