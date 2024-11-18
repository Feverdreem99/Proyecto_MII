using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject levelTransition; // Reference to the level transition object
    public int totalKeys = 3; // Number of keys required

    private int keysCollected = 0;
    // Start is called before the first frame update
    void Start()
    {
        // Ensure the level transition object is disabled at the start
        if (levelTransition != null)
        {
            levelTransition.SetActive(false);
        }
    }

    public void CollectKey()
    {
        keysCollected++;
        int keysLeft = totalKeys - keysCollected;

        // Print the number of keys left
        if (keysLeft > 0)
        {
            Debug.Log($"Keys left to collect: {keysLeft}");
        }

        // Check if all keys are collected
        if (keysCollected >= totalKeys)
        {
            ActivateLevelTransition();
        }
    }

    private void ActivateLevelTransition()
    {
        Debug.Log("All keys collected! Level transition unlocked.");
        levelTransition.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
