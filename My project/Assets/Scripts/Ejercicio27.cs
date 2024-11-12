using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio27 : MonoBehaviour
{

    public Vector3[] points; 
    public float speed = 2f; 

    private int currentPointIndex = 0; 

    // Start is called before the first frame update
    void Start()
    {
        points = new Vector3[]
{
        new Vector3(0, 0, 0),
        new Vector3(5, 0, 0),
        new Vector3(5, 0, 5),
        new Vector3(0, 0, 5)
};
        currentPointIndex = Random.Range(0, points.Length);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, points[currentPointIndex], speed * Time.deltaTime);

  
        if (Vector3.Distance(transform.position, points[currentPointIndex]) < 0.1f)
        {
            // Lo unico diferente de este script con el anterior es que ahora la seleccion entre los indices del arreglo es aleatoria
            int newPointIndex = currentPointIndex;
            while (newPointIndex == currentPointIndex)
            {
                newPointIndex = Random.Range(0, points.Length);
            }


            currentPointIndex = newPointIndex;
        }
    }
}
