using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio31 : MonoBehaviour
{
    public GameObject otherSphere; 

    private Renderer SphereRenderer; 

    // Start is called before the first frame update
    void Start()
    {
        SphereRenderer = otherSphere.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown()
    {
        // Change the color of the other sphere when this one is clicked
        SphereRenderer.material.color = new Color(Random.value, Random.value, Random.value);
    }
}
