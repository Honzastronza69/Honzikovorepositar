using UnityEngine;

public class TankShooting2 : MonoBehaviour
{
    public GameObject Støelaprefab2;  // Prefab projektilu
    public Transform Výstøel2;      // Místo, odkud støela vychází
    public float bulletSpeed = 10f;  // Rychlost støely

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L)) // Støelba klávesou L
        {
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject bullet2 = Instantiate(Støelaprefab2, Výstøel2.position, Výstøel2.rotation);
        Rigidbody2D rb = bullet2.GetComponent<Rigidbody2D>();
        rb.velocity = Výstøel2.up * bulletSpeed;  // Projektil letí smìrem, kam míøí tank
    }
}