using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio18 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Instanciando corrutina
        StartCoroutine(DestroyDelay());
    }

    // Update is called once per frame
    void Update()
    {

        
    }

    // Declarando corrutina que espere 5 segundos para destruir el objeto
    IEnumerator DestroyDelay()
    {
        Debug.Log("Esperando...");
        yield return new WaitForSeconds(3);
        GameObject.Destroy(gameObject);
        Debug.Log("Objeto destruido");
    }
}
