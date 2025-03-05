using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Střílení : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform Výstřel;
    public GameObject Střelaprefab;
    
        public float Střelasíla = 20f;


    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }

    }

    void Shoot()
    {
       GameObject Střela = Instantiate(Střelaprefab, Výstřel.position, Výstřel.rotation);
        Rigidbody2D rb = Střela.GetComponent < Rigidbody2D> ();
        rb.AddForce(Výstřel.up * Střelasíla, ForceMode2D.Impulse);
    }
}