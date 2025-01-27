using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mousefollow : MonoBehaviour
{
    void Update()
    {
        RotateTank();
    }

    void RotateTank()
    {
        // Get the world position of the mouse
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = Camera.main.transform.position.y; // Set this based on your camera height
        Vector3 worldMousePos = Camera.main.ScreenToWorldPoint(mousePos);

        // Get direction from tank to mouse
        Vector3 direction = worldMousePos - transform.position;
        direction.y = 0; // Ignore y-axis for a top-down shooter

        // Calculate rotation
        Quaternion rotation = Quaternion.LookRotation(direction);

        // Rotate the tank
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * 10f); // Adjust speed as needed
    }
}


