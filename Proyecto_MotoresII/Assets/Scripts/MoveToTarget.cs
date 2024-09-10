using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveToTarget : MonoBehaviour
{

    public Transform target; // Assign the cube in the Inspector
    private UnityEngine.AI.NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.SetDestination(target.position);
    }

    // Update is called once per frame
    void Update()
    {
        if (agent.destination != target.position)
        {
            agent.SetDestination(target.position);
        }
    }

    public void SetNewTarget(Transform newTarget)
    {
        target = newTarget;
    }
}
