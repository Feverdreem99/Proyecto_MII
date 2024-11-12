using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio11 : MonoBehaviour
{
    //Variables que almacenan la velocidad del cubo, la posicion maxima y la posicion inicial
    public float speed = 1f; 
    private float resetPositionX = 0f;
    private float maxPositionX = 5f; 

    private void Start()
    {
        
    }
    void Update()
    {
        //Cada frame el cubo se movera a lo largo del eje x (la derecha)
        transform.position += Vector3.right * speed * Time.deltaTime;

        
        //Cuando se llega a la posicion maxima en x la posicion del cubo se reiniciará
        if (transform.position.x >= maxPositionX)
        {
            
            transform.position = new Vector3(resetPositionX, transform.position.y, transform.position.z);
        }
    }
}
