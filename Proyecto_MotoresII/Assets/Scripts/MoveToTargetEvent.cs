using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveToTargetEvent : MonoBehaviour
{
    public GameObject player;
    public CollideAndMove obstacleCollisionDetector;
    public NavMeshAgent navMeshAgent;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        obstacleCollisionDetector = player.GetComponent<CollideAndMove>();

        
    }
    private void Start()
    {
        // Assign the obstacle collision detector and NavMesh agent references in the Inspector
        obstacleCollisionDetector.collideAndMove.AddListener(MoveToObstacle);
    }

    private void MoveToObstacle()
    {
        // Get the obstacle that triggered the collision
        GameObject obstacle = obstacleCollisionDetector.gameObject;

        // Set the NavMesh agent's destination to the obstacle's position
        navMeshAgent.SetDestination(obstacle.transform.position);
    }
}
