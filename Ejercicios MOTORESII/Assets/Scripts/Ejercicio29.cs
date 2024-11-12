using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio29 : MonoBehaviour
{
    public GameObject cubePrefab; 
    private GameObject[] spawnedCubes; 
    private int numberOfCubes = 10; 
    // Start is called before the first frame update
    void Start()
    {
     
        spawnedCubes = new GameObject[numberOfCubes];

       
        for (int i = 0; i < numberOfCubes; i++)
        {
            Vector3 randomPosition = new Vector3(Random.Range(-10f, 10f), 0, 0);
            spawnedCubes[i] = Instantiate(cubePrefab, randomPosition, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
 
        if (Input.GetKeyDown(KeyCode.Space))
        {
 
            for (int i = 0; i < spawnedCubes.Length; i++)
            {
                    if (spawnedCubes[i].transform.position.x > 0)
                    {
                        // Destroy the cube
                        Destroy(spawnedCubes[i]);
                    }
                
            }
        }
    }
}
