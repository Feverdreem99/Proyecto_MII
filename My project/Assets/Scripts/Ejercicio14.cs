using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio14 : MonoBehaviour
{
    public float speed = 2f; 
    public float minPositionX = 0f; 
    public float maxPositionX = 10f;

    private bool movingForward = true; 

    void Update()
    {
        // Moviendo el cubo dependiendo de la posicion
        if (movingForward)
        {
            // Mover hacia adelante (en direccion a x = 10)
            transform.position += Vector3.right * speed * Time.deltaTime;

            // Cambiar de direccion si el cubo llega o supera x = 10
            if (transform.position.x >= maxPositionX)
            {
                movingForward = false;
            }
        }
        else
        {
            //Mover hacia atras (en direccion a x = 0)
            transform.position += Vector3.left * speed * Time.deltaTime;

            // Cambiar de direccion si el cubo llega o supera x = 0
            if (transform.position.x <= minPositionX)
            {
                movingForward = true;
            }
        }
    }
}
