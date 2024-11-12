using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio23 : MonoBehaviour
{
    public GameObject cubePrefab;

    // Numero de filas y columnas
    public int rows = 5;
    public int columns = 3;

    // Declarando distancia entre cubos
    public float spacing = 1.5f;

    void Start()
    {
        // Creando un bucle que vaya entre filas y columnas creando los cubos
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < columns; col++)
            {
                // Calculando la posicion de cada cubo
                Vector3 position = new Vector3(col * spacing, row * spacing, 0);

                // Instanciando el prefab
                Instantiate(cubePrefab, position, Quaternion.identity);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
