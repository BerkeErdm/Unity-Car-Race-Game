using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AI : MonoBehaviour
{
    public GameObject[] sphere;
    NavMeshAgent agent;
    int next = 0;
    float way;

    void Start()
    {
        agent = this.GetComponent<NavMeshAgent>();
    }
	
    void FixedUpdate()
    {
        way = Vector3.Distance(transform.position, sphere [next].transform.position);
        if (way < 7)
        {
            next++;
        }
		
        if (next == sphere.Length)
		{
            next = 0;
        }
		
        agent.SetDestination(sphere[next].transform.position);
    }
}