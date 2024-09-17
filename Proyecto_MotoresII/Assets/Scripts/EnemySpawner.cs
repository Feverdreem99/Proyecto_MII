using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemySpawner : MonoBehaviour
{

    public GameObject cylinderPrefab; // Reference to the cylinder prefab
    public float spawnRadius = 10f; // Radius in which to spawn the cylinder
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnAtRandom()
    {
        Vector3 randomDirection = Random.insideUnitSphere * spawnRadius;
        randomDirection += transform.position; // Random position relative to the spawner's position

        NavMeshHit hit;
        if (NavMesh.SamplePosition(randomDirection, out hit, spawnRadius, NavMesh.AllAreas))
        {
            // Spawn the cylinder at the valid NavMesh point
            Instantiate(cylinderPrefab, hit.position, Quaternion.identity);
        }
        else
        {
            Debug.LogWarning("Could not find a valid point on the NavMesh to spawn the cylinder.");
        }
    }
}
