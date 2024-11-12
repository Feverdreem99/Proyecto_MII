using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio28 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Validar si la tecla espaciadora se presiona
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Creando un arreglo de GameObjects de cada uno en la escena con el tag "desaparecer"
            GameObject[] objectsToDisappear = GameObject.FindGameObjectsWithTag("desaparecer");


            //Recorriendo el arreglo y desactivar cada elemento del mismo
            foreach (GameObject obj in objectsToDisappear)
            {
                obj.SetActive(false);
   
            }

        }
    }
}
