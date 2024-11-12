using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio12 : MonoBehaviour
{
    //Variable que almacena la velocidad de rotacion
    public float rotationSpeed = 100f; 

    private void Start()
    {
        
    }
    void Update()
    {
        // Se valida que la tecla A se presiona para rotar a la izquierda
        if (Input.GetKey(KeyCode.A))
        {
            // Se rota el eje Y por la variable de velocidad cada segundo
            transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
        }

        // Se valida que la tecla D se presiona para rotar a la derecha
        if (Input.GetKey(KeyCode.D))
        {
            // Se rota el eje Y por la variable negativa de velocidad cada segundo
            transform.Rotate(Vector3.up * -rotationSpeed * Time.deltaTime);
        }
    }
}
