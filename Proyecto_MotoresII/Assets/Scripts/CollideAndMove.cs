using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CollideAndMove : MonoBehaviour
{
    public UnityEvent collideAndMove;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Objective"))
        {
            collideAndMove.Invoke();
            Debug.Log("Tocando Objetivo");
        }
    }

  
}
