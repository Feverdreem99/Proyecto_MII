using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio39 : MonoBehaviour
{

    public GameObject redLight;
    public GameObject yellowLight;
    public GameObject greenLight;

    //Duracion de luces
    public float redLightDuration = 5f;  
    public float yellowLightDuration = 2f;
    public float greenLightDuration = 3f; 

    private Renderer redLightRenderer;
    private Renderer yellowLightRenderer;
    private Renderer greenLightRenderer;
    // Start is called before the first frame update
    void Start()
    {
        redLightRenderer = redLight.GetComponent<Renderer>();
        yellowLightRenderer = yellowLight.GetComponent<Renderer>();
        greenLightRenderer = greenLight.GetComponent<Renderer>();

        StartCoroutine(TrafficLightCycle());
    }

    IEnumerator TrafficLightCycle()
    {
        while (true)
        {

            SetLightState(Color.red, Color.black, Color.black);
            yield return new WaitForSeconds(redLightDuration);


            SetLightState(Color.black, Color.black, Color.green);
            yield return new WaitForSeconds(greenLightDuration);


            SetLightState(Color.black, Color.yellow, Color.black);
            yield return new WaitForSeconds(yellowLightDuration);
        }
    }

    void SetLightState(Color red, Color yellow, Color green)
    {
        redLightRenderer.material.color = red;
        yellowLightRenderer.material.color = yellow;
        greenLightRenderer.material.color = green;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
