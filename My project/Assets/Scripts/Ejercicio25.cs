using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio25 : MonoBehaviour
{
    // Declarando variables para los 3 prefabs a utilizar
    public GameObject cubePrefab1;
    public GameObject cubePrefab2;
    public GameObject cubePrefab3;

    // Numero de cubos en cada eje
    public int gridSize = 6;

    // Distancia entre cubos
    public float spacing = 1.5f;

    void Start()
    {
        // Creando un bucle entre los 3 ejes para formar el cubo
        for (int x = 0; x < gridSize; x++)
        {
            for (int y = 0; y < gridSize; y++)
            {
                for (int z = 0; z < gridSize; z++)
                {
                    // Calculando la posicion para cada cubo creado
                    Vector3 position = new Vector3(x * spacing, y * spacing, z * spacing);

                    // Eligiendo un prefab aleatorio de los 3 posibles
                    GameObject chosenPrefab = GetRandomPrefab();

                    // Instanciar el prefab de la posicion calculada
                    Instantiate(chosenPrefab, position, Quaternion.identity);
                }
            }
        }
    }

    
    private void Update()
    {
            
    }

    // Funcion para seleccionar uno de los 3 prefabs aleatoreamente
    GameObject GetRandomPrefab()
    {
        int randomIndex = Random.Range(0, 3);  // Seleccionar al azar entre los 3 casos
        switch (randomIndex)
        {
            case 0:
                return cubePrefab1;
            case 1:
                return cubePrefab2;
            case 2:
                return cubePrefab3;
            default:
                return cubePrefab1; 
        }
    }
}
