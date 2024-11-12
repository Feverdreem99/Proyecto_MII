using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private GameObject[] newtonObjects; // Array to hold objects with the "newton" tag
    // Start is called before the first frame update
    void Start()
    {
        // Find all objects with the "newton" tag in the scene
        newtonObjects = GameObject.FindGameObjectsWithTag("newton");

        // Initially, disable gravity for all objects
        foreach (GameObject obj in newtonObjects)
        {
            Rigidbody rb = obj.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.useGravity = false;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Check if the spacebar is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Enable gravity for all objects tagged with "newton"
            foreach (GameObject obj in newtonObjects)
            {
                Rigidbody rb = obj.GetComponent<Rigidbody>();
                if (rb != null)
                {
                    rb.useGravity = true;
                }
            }
        }
    }
}
