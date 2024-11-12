using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio27 : MonoBehaviour
{

    public Vector3[] points; // Array of points (coordinates) for the cube to move along
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
        currentPointIndex = Random.Range(0, points.Length);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, points[currentPointIndex], speed * Time.deltaTime);

        // Check if the cube has reached the current point
        if (Vector3.Distance(transform.position, points[currentPointIndex]) < 0.1f)
        {
            // Choose a new random point, making sure it's different from the current one
            int newPointIndex = currentPointIndex;
            while (newPointIndex == currentPointIndex)
            {
                newPointIndex = Random.Range(0, points.Length);
            }

            // Update the current point index to the new random point
            currentPointIndex = newPointIndex;
        }
    }
}
