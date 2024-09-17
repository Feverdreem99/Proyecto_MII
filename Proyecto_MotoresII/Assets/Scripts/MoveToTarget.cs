using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveToTarget : MonoBehaviour
{

    public Transform target; // Assign the cube in the Inspector
    private NavMeshAgent agent;

   
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        // Check if there's a target and move towards it
        if (target != null)
        {
            agent.SetDestination(target.position);
        }

    }





    public void SetNewTarget(Transform newTarget)
    {
        target = newTarget;
    }


}
