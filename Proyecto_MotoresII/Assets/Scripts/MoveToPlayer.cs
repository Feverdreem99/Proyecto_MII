using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveToPlayer : MonoBehaviour
{

    public NavMeshAgent agent; // Reference to the NavMeshAgent component
    public Transform player; // Reference to the player object (sphere)

    public float normalSpeed = 1.5f; // Normal wandering speed
    public float chaseSpeed = 5f; // Speed when chasing the player

    public float chaseRadius = 4f; // Radius in which the cylinder will chase the player
    public float wanderRadius = 10f; // Radius within which the cylinder will wander
    public float waitTimeAfterTarget = 3f; // Time to wait after reaching a target before wandering again

    private bool isWandering = true; // Is the cylinder currently wandering?
    private bool isChasing = false; // Is the cylinder currently chasing the player?
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.speed = normalSpeed;
        StartWandering(); // Start wandering initially
    }

    // Update is called once per frame
    void Update()
    {
        // Calculate the distance between the player and the cylinder
        float distanceToPlayer = Vector3.Distance(player.position, transform.position);

        // If the player is within the chase radius, start chasing the player
        if (distanceToPlayer <= chaseRadius)
        {
            StartChasing();
        }
        // If the player is outside the chase radius, resume wandering
        else if (isChasing && distanceToPlayer > chaseRadius)
        {
            StartCoroutine(ResumeWanderingAfterDelay());
        }

        // If the cylinder is wandering and reached its wandering destination, find a new one
        if (isWandering && !agent.pathPending && agent.remainingDistance <= agent.stoppingDistance)
        {
            Wander();
        }

        // If the cylinder is chasing the player, update the destination to the player's position
        if (isChasing)
        {
            agent.SetDestination(player.position);
        }
    }

    void StartChasing()
    {
        agent.speed = chaseSpeed;
        isWandering = false; // Stop wandering
        isChasing = true; // Start chasing
    }

    // Function to start the wandering behavior
    void StartWandering()
    {
        agent.speed = normalSpeed;
        isWandering = true;
        isChasing = false;
        Wander(); // Find a random point to move to
    }

    // Function that makes the cylinder move to a random point within the NavMesh
    void Wander()
    {
        Vector3 randomDirection = Random.insideUnitSphere * wanderRadius;
        randomDirection += transform.position;

        NavMeshHit hit;
        if (NavMesh.SamplePosition(randomDirection, out hit, wanderRadius, 1))
        {
            Vector3 finalPosition = hit.position;
            agent.SetDestination(finalPosition);
        }
    }

    IEnumerator ResumeWanderingAfterDelay()
    {
        yield return new WaitForSeconds(waitTimeAfterTarget);
        StartWandering(); // Start wandering again after a delay
    }
}
