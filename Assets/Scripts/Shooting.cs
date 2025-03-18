using UnityEngine;

public class TankShooting : MonoBehaviour
{
    public GameObject Støelaprefab;   // Prefab projektilu
    public Transform Výstøel;         // Místo, odkud støela vychází
    public float bulletSpeed = 10f;   // Rychlost støely
    public float shootCooldown = 2f;  // Cooldown mezi støelami (v sekundách)
    private float lastShotTime = 0f;  // Èas poslední støely

    void Update()
    {
        // Pokud je stisknuto tlaèítko "F" a cooldown je dokonèen
        if (Input.GetKeyDown(KeyCode.Space) && Time.time >= lastShotTime + shootCooldown)
        {
            Shoot();
            lastShotTime = Time.time;  // Aktualizuje èas poslední støely
        }
    }

    void Shoot()
    {
        // Vytvoøení projektilu
        GameObject bullet = Instantiate(Støelaprefab, Výstøel.position, Výstøel.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.velocity = Výstøel.up * bulletSpeed;  // Projektil letí smìrem, kam míøí tank
    }
}
