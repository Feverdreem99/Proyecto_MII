using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio32 : MonoBehaviour
{

    private Rigidbody sphereRigidbody; 
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
       
        if (collision.gameObject.CompareTag("Ground"))
        {
           
            sphereRigidbody.AddForce(Vector3.up * 200f); 
        }
    }
}
