using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio10 : MonoBehaviour
{
    //Variables que almacenan ambos numeros a evaluar
    private int firstnumber;
    private int secondnumber;
   

    private IEnumerator corountine;
    // Start is called before the first frame update
    void Start()
    {
        //Se inicia el proyecto y se genera un numero aleatorio entre 0 y 100, se almacena en la primera variable
        firstnumber = Random.Range(0, 100);
    }

    // Update is called once per frame
    void Update()
    {
        //La corrutina se inicia cada vez que se presiona la barra espaciadora
        if (Input.GetKeyDown(KeyCode.Space))
        {
            corountine = WaitSeconds(10f, firstnumber, secondnumber);
            StartCoroutine(corountine);
        }
        
    }

    //Corrutina iniciada que genera un nuevo numero despues de 10 segundos y lo evalua con el primer numero
    private IEnumerator WaitSeconds(float waittime, int num1, int num2)
    {
        Debug.Log("Generando...");
        //Se interrumpe la corrutina por 10 segundos
        yield return new WaitForSeconds(waittime);
        //Luego de 10 segundos un numero nuevo se genera entre 0 y 100
        num2= Random.Range(0, 100);

        //Si el numero generado es mayor al que se genero anteriormente si imprime Acierto, sino se imprime Fallo
        if (num2 > num1)
        {
            Debug.Log("Acierto!");
        }
        else
        {
            Debug.Log("Fallo!");
        }
    }

}
