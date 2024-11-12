using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio16 : MonoBehaviour
{
    private Vector3 zposition;
    public GameObject movableobject;
    // Start is called before the first frame update
    void Start()
    {
        zposition.z = movableobject.transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {

        // Al presionar tecla espaciadora incrementar la posicion en z del objeto por 1
        if(Input.GetKeyDown(KeyCode.Space))
        {
            zposition.z ++;
            movableobject.transform.position = new Vector3(0, 0, zposition.z);
        }


    }
}
