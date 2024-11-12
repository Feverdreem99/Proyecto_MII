using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio26 : MonoBehaviour
{
    private Vector3[] points; // Array of points (coordinates) for the cube to move along
    public float speed = 2f; // Movement speed

    private int currentPointIndex = 0; // Index of the current point the cube is moving toward

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
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, points[currentPointIndex], speed * Time.deltaTime);
        // Check if the cube has reached the current point
        if (Vector3.Distance(transform.position, points[currentPointIndex]) < 0.1f)
        {
            // Move to the next point
            currentPointIndex++;

            // If we reached the last point, start from the first one again
            if (currentPointIndex >= points.Length)
            {
                currentPointIndex = 0;
            }
        }
    }
}
