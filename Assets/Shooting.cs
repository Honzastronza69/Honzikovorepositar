using UnityEngine;

public class TankShooting : MonoBehaviour
{
    public GameObject Støelaprefab;  // Prefab projektilu
    public Transform Výstøel;      // Místo, odkud støela vychází
    public float bulletSpeed = 10f;  // Rychlost støely

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F)) // Støelba klávesou "F"
        {
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(Støelaprefab, Výstøel.position, Výstøel.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.velocity = Výstøel.up * bulletSpeed;  // Projektil letí smìrem, kam míøí tank
    }
}