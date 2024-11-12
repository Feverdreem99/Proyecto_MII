using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio6 : MonoBehaviour
{
    //Se declara el numero a evaluar
    public int number;
    // Start is called before the first frame update
    void Start()
    {
        //Se declara una variable para almacenar el resultado de la factorial del numero
        int factorial = CalculateFactorial(number);
        Debug.Log("La factorial de" + number + " es " + factorial);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Metodo para calcular la factorial del numero previamente declarado
    public int CalculateFactorial(int number)
    {
      
        //Se inicia el metodo con el primer numero de las cifras del factorial
        int result = 1;

        //Se inicia un bucle que se repite hasta que se llega al numero declarado, cada ciclo del bucle, el numero actual del ciclo se multiplica con el valor previo de la variable result
        for (int i = 1; i <= number; i++)
        {
            result *= i;
        }

        //Se retorna el valor final del bucle
        return result;
    }
}
