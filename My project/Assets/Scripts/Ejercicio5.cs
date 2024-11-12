using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5 : MonoBehaviour
{
    //Declarando variable que almacena el dia de hoy
    private DayOfWeek today = DateTime.Now.DayOfWeek;
    

    //Metodo que revisa si el dia de hoy es igual a jueves, si lo es, el mensaje se muestra en consola
    void DayCheck()
    {
        if(today==DayOfWeek.Thursday)
        {
            Debug.Log("Hoy es " + today);
        }
        else
        {
            Debug.Log("Hoy no es jueves");
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        //El metodo se ejecuta al iniciar el proyecto
        DayCheck();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
