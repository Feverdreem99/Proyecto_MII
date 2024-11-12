using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio22 : MonoBehaviour
{

    public int numberOfCubes = 10;

    public float spacing = 1.5f;

    void Start()
    {
        //Creando un bucle que se repita por el numero de cubos desesado
        for (int i = 0; i < numberOfCubes; i++)
        {
            //Cada repeticion del bucle un objeto nuevo se creara
            GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube.transform.position = new Vector3(i * spacing, 0, 0);
            cube.transform.localScale = new Vector3(1, 1, 1);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
