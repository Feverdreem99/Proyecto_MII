using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio15 : MonoBehaviour
{
    public float moveSpeed = 5f; // Speed of movement

    void Update()
    {
        // Consiguiendo el input de teclas direccionales o WASD
        float moveX = Input.GetAxis("Horizontal"); // teclas direccionales izq/der o A/D
        float moveZ = Input.GetAxis("Vertical");   // teclas direccionales arb/abj o W/S

        // Creando vector de movimiento basado en input
        Vector3 move = new Vector3(moveX, 0, moveZ);

        // Aplicando movimiento a posicion del cubo
        transform.position += move * moveSpeed * Time.deltaTime;
    }
}
