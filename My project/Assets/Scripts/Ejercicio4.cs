using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;

public class Ejercicio4 : MonoBehaviour
{
    //Declarando variable booleana para revisar si la suma es par o no
    private bool sumCheck = false;

    //Declarando variables para utilizar en las operaciones
    public int DataA;
    public int DataB;

    //Metodo que suma las variables y valida si el resultado es par
    void DataSum()
    {
        //Validar que los numeros admitidos sean unicamente positivos
        if (DataA <0 || DataB <0)
        {
            Debug.Log("Datos Inadminitdos");
            return;
        }
        int sumTotal = DataA + DataB;
        if (sumTotal==0)
        {
            Debug.Log("La suma es igual a 0");
            return;
        }

        //Variables que almacena el residuo de la division de la suma entre 2
        int checkEvenOdd = sumTotal % 2;

        //Si el residuo de la division es 0, la suma es par
        if(checkEvenOdd==0)
        {
            sumCheck = true;
            Debug.Log("El resultado de " + DataA + " mas " + DataB + " es igual a: " + sumTotal + ", el resultado es par");
            Debug.Log(sumCheck);
        }
        //Si el resultado no es 0, la suma es impar
        else 
        {
            Debug.Log("El resultado de " + DataA + " mas " + DataB + " es igual a: " + sumTotal + ", el resultado es impar");
            Debug.Log(sumCheck);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        //Ejecutando el metodo al iniciar el proyecto
        DataSum();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
