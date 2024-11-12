using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercico9 : MonoBehaviour
{
    //Variables que almacenan el numero de frames al ejecutar el proyecto y el numero desesado de frames
    private int currentframes = 0;
    private int targetframes = 100;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Se aumenta el numero de frames por 1
        currentframes++;
        //Cuando se aumentan los frames hasta llegar al numero deseado se muestra el tiempo desde la ejecucion del proyecto hasta que llego al numero desesado de frames
        if(currentframes >= targetframes)
        {
            Debug.Log("Tiempo desde ejecucion de juego " + Time.time + " segundos");
            //Se reinicia el numero de frames
            currentframes= 0;
        }
    }
}
