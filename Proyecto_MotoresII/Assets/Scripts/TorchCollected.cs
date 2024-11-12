using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorchCollected : MonoBehaviour
{

    private bool isCollected = false;
    private Transform playerTransform;
    private PlayerInventory playerInventory;
    private Renderer lightRenderer;
    private Light pointLight;

    void Start()
    {
        // Get the renderer and light component to enable/disable visibility
        lightRenderer = GetComponent<Renderer>();
        pointLight = GetComponentInChildren<Light>();
    }

    void Update()
    {
        // If the light is collected, follow the player (even though it's not visible)
        if (isCollected && playerTransform != null)
        {
            transform.position = playerTransform.position + playerTransform.forward * 1.5f;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !isCollected)
        {
            // Collect the light
            playerInventory = other.GetComponent<PlayerInventory>();
            if (playerInventory != null)
            {
                playerInventory.CollectLight(this);
                isCollected = true;
                playerTransform = other.transform;

                // Make the light invisible
                SetLightVisibility(false);
            }
        }
    }

    public void PlaceLight(Vector3 position)
    {
        isCollected = false;
        transform.position = position;
        playerTransform = null;

        // Make the light visible
        SetLightVisibility(true);
    }

    // Method to toggle visibility of the light
    private void SetLightVisibility(bool isVisible)
    {
        lightRenderer.enabled = isVisible;
        pointLight.enabled = isVisible;
    }
}
