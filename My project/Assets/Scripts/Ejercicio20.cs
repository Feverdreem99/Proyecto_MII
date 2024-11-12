using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio20 : MonoBehaviour
{
    int timesclicked = 0;
    // Start is called before the first frame update
    void Start()
    {
        //string currentname = gameObject.name;
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    //Creando un contador para las veces que se clickea un objeto
    private void OnMouseDown()
    {
        //Incrementando por uno cada vez que el metodo se activa
        timesclicked++;

        //Definiendo nombre de objeto como las veces que se ha clickeado
        string newname = "Veces clickeado "+ timesclicked;
        gameObject.name = newname;
        Debug.Log("Nombre actualizado: " + newname);

    }
}
