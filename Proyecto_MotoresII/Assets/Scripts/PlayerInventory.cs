using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    private TorchCollected collectedLight;

    void Update()
    {
        // If the player presses the X key and has collected the light
        if (Input.GetKeyDown(KeyCode.X) && collectedLight != null)
        {
            PlaceLightInFrontOfPlayer();
        }
    }

    public void CollectLight(TorchCollected light)
    {
        collectedLight = light;
        Debug.Log("Light collected!");
    }

    private void PlaceLightInFrontOfPlayer()
    {
        // Calculate the position in front of the player
        Vector3 placementPosition = transform.position + transform.forward * 2f;

        // Place the light and clear it from inventory
        collectedLight.PlaceLight(placementPosition);
        collectedLight = null;
    }
}
