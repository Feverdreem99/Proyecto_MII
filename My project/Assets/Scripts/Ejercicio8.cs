using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio8 : MonoBehaviour
{

    //Variable declarada para almacenar el tiempo al inicio del frame
    private float lastFrameTime;
    // Start is called before the first frame update
    void Start()
    {
        lastFrameTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        //Se calcula el tiempo desde el ultimo frame restando el tiempo al inicio del frame actual del tiempo del inicio del frame anterior
        float deltaTime = Time.time - lastFrameTime;

        //Se imprimer el tiempo en segundos
        Debug.Log($"Time since last frame: {deltaTime} seconds");

        //Se actualiza el valor del tiempo de inicio del frame anterior
        lastFrameTime = Time.time;

    }
}
