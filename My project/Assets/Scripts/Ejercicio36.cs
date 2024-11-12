using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio36 : MonoBehaviour
{

    public float destructionRange = 10f; // Range in units within which objects will be destroyed
    public string targetTag = "Destroyable"; // Tag to identify which objects can be destroyed
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        GameObject[] objectsToDestroy = GameObject.FindGameObjectsWithTag(targetTag);

        foreach (GameObject obj in objectsToDestroy)
        {
            float distance = Vector3.Distance(transform.position, obj.transform.position);

            if (distance <= destructionRange)
            {
                Destroy(obj);
            }
        }
    }
}
