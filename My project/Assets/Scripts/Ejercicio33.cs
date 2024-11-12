using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio33 : MonoBehaviour
{

    public float upwardForce = 10f; 
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.S))
        {

            rb.AddForce(Vector3.up * upwardForce);
        }
    }
}
