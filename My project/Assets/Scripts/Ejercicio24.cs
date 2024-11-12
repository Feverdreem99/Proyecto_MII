using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio24 : MonoBehaviour
{
    public GameObject cubePrefab;

    
    public int gridSize = 6;

    
    public float spacing = 1.5f;

    void Start()
    {
        for (int x = 0; x < gridSize; x++)
        {
            for (int y = 0; y < gridSize; y++)
            {
                for (int z = 0; z < gridSize; z++)
                {
                    Vector3 position = new Vector3(x * spacing, y * spacing, z * spacing);

                    Instantiate(cubePrefab, position, Quaternion.identity);
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
