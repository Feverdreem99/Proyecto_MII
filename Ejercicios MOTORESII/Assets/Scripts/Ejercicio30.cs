using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio30 : MonoBehaviour
{
    private Renderer sphereRenderer; 
    // Start is called before the first frame update
    void Start()
    {
        sphereRenderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        // Change to a random color when the sphere is clicked
        sphereRenderer.material.color = new Color(Random.value, Random.value, Random.value);
    }
}
