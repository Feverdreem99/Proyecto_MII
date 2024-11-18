using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProximityAudio : MonoBehaviour
{
    public GameObject player; // Reference to the player
    public float maxVolume = 1.0f; // Maximum volume
    public float maxDistance = 10.0f; // Distance at which the volume starts increasing

    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.volume = 0; // Start with no volume
        audioSource.Play(); // Start playing the audio loop
    }

    // Update is called once per frame
    void Update()
    {
        // Calculate the distance between the player and the audio source
        float distance = Vector3.Distance(player.transform.position, transform.position);

        // Calculate volume based on proximity
        float volume = Mathf.Clamp(1 - (distance / maxDistance), 0, maxVolume);
        audioSource.volume = volume;
    }
}
