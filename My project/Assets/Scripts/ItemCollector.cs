using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ItemCollector : MonoBehaviour
{
    public static event Action OnItemCollected;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Picked up an item");

            if (OnItemCollected != null)
            {
                OnItemCollected.Invoke();
            }
        }
    }
}
