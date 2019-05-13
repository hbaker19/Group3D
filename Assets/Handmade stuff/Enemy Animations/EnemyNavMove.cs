using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class EnemyNavMove : MonoBehaviour {

    // Use this for initialization
    //store the nav mesh agent
    NavMeshAgent agent;
	public GameObject player;
	public float chaseDistance = 10;
	private Vector3 home;
    public Animator animator;

	void Start () {
		home = transform.position;
        agent = GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {
        //move the object towards the destination, which in this case
        //is the player
		Vector3 direction = player.transform.position - transform.position;
        if(direction.magnitude <= chaseDistance){
			agent.destination = player.transform.position;
            GetComponent<Animator>().SetBool("Standing Still", false);
            GetComponent<Animator>().SetBool("Looking Around", false);
            GetComponent<Animator>().SetBool("Start Chasing", true);
        }
        else{
			agent.destination = home;
            GetComponent<Animator>().SetBool("Start Chasing", false);
            GetComponent<Animator>().SetBool("Start Pacing", true);
        }
	}
}
