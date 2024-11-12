using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerSample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SoundManager.instance.masterVolume = 0.8f;
        SoundManager.instance.musicVolume = 0.7f;
        SoundManager.instance.effectsVolume = 0.9f;

        // Print the updated values to the console
        Debug.Log("Master Volume: " + SoundManager.instance.masterVolume);
        Debug.Log("Music Volume: " + SoundManager.instance.musicVolume);
        Debug.Log("Effects Volume: " + SoundManager.instance.effectsVolume);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
