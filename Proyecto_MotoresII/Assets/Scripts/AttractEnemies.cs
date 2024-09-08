using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttractEnemies : MonoBehaviour

{
    public Transform attractPoint;  
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))  
        {
            EnemyAI[] enemies = FindObjectsOfType<EnemyAI>();
            foreach (EnemyAI enemy in enemies)
            {
                enemy.MoveToPoint(attractPoint.position);
            }
        }
    }
}
