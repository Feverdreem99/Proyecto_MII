using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2 : MonoBehaviour
{
    //Valores requeridos para las operaciones
    public float DataA;
    public float DataB;

    //Variables en las que se almacenara el resultado de las operaciones
    private float sumResult;
    private float resResult;
    private float multResult;
    private float divResult;

    // Start is called before the first frame update

    //metodo que maneja las operaciones con los valores previamente ingresados y los muestra en consola
    void Operations()
    {
        //suma
        sumResult = DataA + DataB;
        Debug.Log("Resultado de suma: " + sumResult);
        //resta
        resResult = DataA - DataB;
        Debug.Log("Resultado de resta: " + resResult);
        //multiplicacion
        multResult = DataA * DataB;
        Debug.Log("Resultado de multiplicacion: " + multResult);
        //division
        divResult = DataA / DataB;
        Debug.Log("Resultado de division: " + divResult);

    }
    void Start()
    {
        //ejecutando el metodo al iniciar el proyecto, se realizan todas las operaciones
        Operations();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
