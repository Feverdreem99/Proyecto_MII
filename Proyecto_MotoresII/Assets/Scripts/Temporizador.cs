using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Temporizador : MonoBehaviour
{
    public Text TextoTemporizador;
    private float TiempoTranscurrido = 0f;
    public float intervaloFortalecimiento = 30f;  
    private float tiempoParaFortalecer = 0f;

    void Update()
    {
        
        TiempoTranscurrido += Time.deltaTime;

      
        if (TextoTemporizador != null)
        {
            int minutos = Mathf.FloorToInt(TiempoTranscurrido / 60);
            int segundos = Mathf.FloorToInt(TiempoTranscurrido % 60);
            TextoTemporizador.text = string.Format("{0:00}:{1:00}", minutos, segundos);
        }
        else
        {
            Debug.LogError("Texto del temporizador no ha sido asignado en el Inspector.");
        }

       
        tiempoParaFortalecer += Time.deltaTime;

     
        if (tiempoParaFortalecer >= intervaloFortalecimiento)
        {
            Debug.Log("Enemigos fortalecidos"); 
            tiempoParaFortalecer = 0f;           
        }
    }
}
