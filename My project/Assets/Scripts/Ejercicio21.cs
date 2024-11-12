using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio21 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int sum = 0;

        
        for (int i = 0; i < 500; i++)
        {
            int evenNumber = i * 2;
            sum += evenNumber;
        }

        Debug.Log("La suma de los primeros 500 numeros pares es: " + sum);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
