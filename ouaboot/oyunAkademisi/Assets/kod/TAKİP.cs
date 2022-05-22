using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class TAKİP : MonoBehaviour
{
    NavMeshAgent agent;
    public Transform target;
    public float mesafe;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        mesafe = Vector3.Distance(transform.position, target.position);

        if (mesafe > 0.8f)
        {
            agent.destination = target.position;
            agent.speed = 2;
        }
        if (mesafe < 0.8f)
        {
            agent.destination = target.position;
            agent.speed = 0;
        }

    }
}
