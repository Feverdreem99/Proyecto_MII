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
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject[] objectsToDisappear = GameObject.FindGameObjectsWithTag("desaparecer");


            foreach (GameObject obj in objectsToDisappear)
            {
                obj.SetActive(false);
   
            }

        }
    }
}
