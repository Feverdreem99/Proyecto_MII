using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class ShakeTrigger : MonoBehaviour
{
    public CinemachineVirtualCamera virtualCamera;
    private CinemachineBasicMultiChannelPerlin cameraNoise;
    public float shakeAmplitude = 0.2f; // Adjust this for intensity
    public float shakeFrequency = 20.0f; // Adjust this for speed

    private float defaultAmplitude;
    private float defaultFrequency;

    void Start()
    {
        // Get the noise component from the virtual camera
        cameraNoise = virtualCamera.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>();

        // Store the default noise values
        defaultAmplitude = cameraNoise.m_AmplitudeGain;
        defaultFrequency = cameraNoise.m_FrequencyGain;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            // Enable shaking by increasing amplitude and frequency
            cameraNoise.m_AmplitudeGain = shakeAmplitude;
            cameraNoise.m_FrequencyGain = shakeFrequency;
        }
        else
        {
            // Reset to default values when the spacebar is not pressed
            cameraNoise.m_AmplitudeGain = defaultAmplitude;
            cameraNoise.m_FrequencyGain = defaultFrequency;
        }
    }
}