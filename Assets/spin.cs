using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spin : MonoBehaviour
{
    public float rotationSpeed = 100f; // Adjust the speed of rotation

    private void Update()
    {
        // Rotate the object around the Z-axis to make it spin in a circle
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }
}
