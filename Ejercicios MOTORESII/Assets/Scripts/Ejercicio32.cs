using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio32 : MonoBehaviour
{

    private Rigidbody sphereRigidbody; // Reference to the Rigidbody component
    // Start is called before the first frame update
    void Start()
    {
        // Get or add the Rigidbody component to the sphere
        sphereRigidbody = gameObject.GetComponent<Rigidbody>();
        sphereRigidbody.useGravity = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            sphereRigidbody.useGravity = true;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        // Make the sphere bounce on collision with the ground or other objects
        if (collision.gameObject.CompareTag("Ground"))
        {
            // You can adjust the bounciness via physics materials or programmatically if needed
            sphereRigidbody.AddForce(Vector3.up * 200f); // Example bounce force
        }
    }
}
