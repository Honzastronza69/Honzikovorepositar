using UnityEngine;

public class TankShooting2 : MonoBehaviour
{
    public GameObject Støelaprefab2;  // Prefab projektilu
    public Transform Výstøel2;        // Místo, odkud støela vychází
    public float bulletSpeed = 10f;   // Rychlost støely
    public float shootCooldown = 2f;  // Cooldown mezi støelami (v sekundách)
    private float lastShotTime = 0f;  // Èas poslední støely

    void Update()
    {
        // Pokud je stisknuto tlaèítko 0, tank vystøelí
        if (Input.GetKeyDown(KeyCode.RightShift) && Time.time >= lastShotTime + shootCooldown)
        {
            Shoot();
            lastShotTime = Time.time;  // Aktualizuj èas poslední støely
        }
    }

    void Shoot()
    {
        // Vytvoøení projektilu
        GameObject bullet2 = Instantiate(Støelaprefab2, Výstøel2.position, Výstøel2.rotation);
        Rigidbody2D rb = bullet2.GetComponent<Rigidbody2D>();
        rb.velocity = Výstøel2.up * bulletSpeed;  // Projektil letí smìrem, kam míøí tank
    }
}
