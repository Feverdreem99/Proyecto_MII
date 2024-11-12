using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio13 : MonoBehaviour
{
    //Declarando variables de escala por la cual se incrementara el cubo y el limite de tamaño
    public float sizeIncreaseRate = 0.25f;
    public float maxScaleDuration = 10f;
    public Vector3 minSize = Vector3.one;

    //Declarando variable para almacenar tamaño inicial
    private Vector3 originalSize;
    private float scaleTime = 0f; 

    void Start()
    {
        //inicializando tamaño inicial como tamaño actual
        originalSize = transform.localScale;
    }

    void Update()
    {
        
        if (Input.GetKey(KeyCode.Space))
        {
            // Incrementar el tamaño si no se ha alcanzado el tamaño maximo
            if (scaleTime < maxScaleDuration)
            {
                scaleTime += Time.deltaTime; // Se incrementa el tiempo que se pasa aumentando el tamaño
                float scaleFactor = 1 + sizeIncreaseRate * scaleTime; // Se calcula el nuevo factor de tamaño
                transform.localScale = originalSize * scaleFactor; // Modificando el tamaño actual al factor de tamaño
            }
        }
        else
        { 
            //Se reinicia la escala de tiempo cuando la tecla se suelta
            scaleTime = 0f; 
            transform.localScale = Vector3.Max(transform.localScale - Vector3.one * sizeIncreaseRate * Time.deltaTime, minSize);
        }
    }
}
