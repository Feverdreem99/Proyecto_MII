using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveToTarget : MonoBehaviour
{

    public Transform target; // Assign the cube in the Inspector
    public GameObject targetGameObject;
    private NavMeshAgent agent;

    private void Awake()
    {
        targetGameObject = GameObject.FindGameObjectWithTag("Objective");
        target = targetGameObject.transform;
    }
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
