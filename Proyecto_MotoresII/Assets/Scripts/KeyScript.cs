using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScript : MonoBehaviour
{
    public GameManager gameManager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Notify GameManager that a key was collected
            gameManager.CollectKey();
            // Destroy the key object
            Destroy(gameObject);
        }
    }
}
