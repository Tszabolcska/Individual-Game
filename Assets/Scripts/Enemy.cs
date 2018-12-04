using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.AI;

public class Enemy : MonoBehaviour {

    //public UnityEvent OnDestroy;
    public int scoreValue = 10;
    public GameObject enemy;
    public GameObject sickEnemy;
    public Transform target;
    private NavMeshAgent agent;
    public float EnemyDistance = 20.0f;
    public float nutrients = 50.0f;
    public float staminaDamage = 0.0f;


    
    // Use this for initialization
    void Start () {
        agent = GetComponent<NavMeshAgent>();
    }
	
	// Update is called once per frame
	void Update () {
        float distance = Vector3.Distance(transform.position, target.position);
        Debug.Log("Distance: " + distance);
        //if (target != null)
        //{    
        //    agent.destination = target.position;
        //}
        if (distance < EnemyDistance)
        {
            Vector3 dirToPlayer = transform.position - target.position;
            Vector3 newPos = transform.position + dirToPlayer;
            agent.SetDestination(newPos);
        }
    }
}
