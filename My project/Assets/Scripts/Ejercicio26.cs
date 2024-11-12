using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio26 : MonoBehaviour
{
    // Arreglo de coordenadas en las que el cubo se mueve
    private Vector3[] points; 
    public float speed = 2f;

    // Indice del punto actual al que se mueve el cubo
    private int currentPointIndex = 0; 

    // Start is called before the first frame update
    void Start()
    {
        points = new Vector3[]
  {
      //Estableciendo puntos para llenar el arreglo
        new Vector3(0, 0, 0),
        new Vector3(5, 0, 0),
        new Vector3(5, 0, 5),
        new Vector3(0, 0, 5)
  };
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, points[currentPointIndex], speed * Time.deltaTime);
        // Validar si el cubo ha llegado a la posicion del indice
        if (Vector3.Distance(transform.position, points[currentPointIndex]) < 0.1f)
        {
            // Incrementar el numero del indice para moverse a el
            currentPointIndex++;

            // Si se llega al ultimo, regresar al indice 0
            if (currentPointIndex >= points.Length)
            {
                currentPointIndex = 0;
            }
        }
    }
}
