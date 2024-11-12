using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio19 : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        StartCoroutine(DestroyDelayRange());
    }

    //Declarando Corrutina que utilice rango de 2 numeros para utilizar como segundos a esperar
    IEnumerator DestroyDelayRange()
    {
        //Creando una lista de los 2 valores a utilizar
    List<int> specificValues = new List<int> { 3, 5 };
        //Definiendo una variable que almacene un indice aleatorio de la lista creada
    int timerrangeindex = Random.Range(0,specificValues.Count);
        //Definiendo la variable que almacene los segundos a utilizar segun el indice generado 
    int timerange = specificValues[timerrangeindex];
    Debug.Log("Esperando...");
        //Utilizando la variable como los segundos a esperar

        yield return new WaitForSeconds(timerange);
        GameObject.Destroy(gameObject);
        Debug.Log("Objeto destruido en: "+timerange+" segundos.");
    }
}
