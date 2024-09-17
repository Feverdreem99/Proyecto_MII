using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Temporizador : MonoBehaviour
{
    public MoveToPlayer chaserEnemy;
    public EnemySpawner spawnListener;
    public TMP_Text TextoTemporizador;
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
            chaserEnemy.normalSpeed = chaserEnemy.normalSpeed + 2;
            chaserEnemy.chaseSpeed = chaserEnemy.normalSpeed + 2;
            spawnListener.SpawnAtRandom();
            Debug.Log("Enemigos fortalecidos"); 
            tiempoParaFortalecer = 0f;           
        }
    }

    
}
