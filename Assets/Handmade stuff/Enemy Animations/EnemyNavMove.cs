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
        //Move the object towards the destination, which in this case is the player
		Vector3 direction = player.transform.position - transform.position;

        //If the player is within range,
        if(direction.magnitude <= chaseDistance){
            //Start chasing.
			agent.destination = player.transform.position;
            animator.SetBool("Looking Around", false);
            animator.SetBool("Start Chasing", true);
            animator.SetBool("Chasing", true);
            animator.SetBool("Going Home", false);
        }
        else if ((transform.position - home).magnitude >= 1){
            //Otherwise, go home.
            agent.destination = home;
            animator.SetBool("Start Chasing", false);
            animator.SetBool("Chasing", false);
            animator.SetBool("Going Home", true);
        }
        else
        {
            animator.SetBool("Looking Around", true);
        }
        Debug.Log(transform.position + " " + home);
    }

    private void OnTriggerEnter(Collider other)
    {
        //If the enemy walks into a trigger on the player,
        if (other.gameObject.tag == "Player")
        {
            //Start attacking.
            animator.SetBool("Start Attacking", true);
            animator.SetBool("Attacking", true);
            animator.SetBool("Start Chasing", false);
            animator.SetBool("Chasing", false);
        }   
    }

    private void OnTriggerExit(Collider other)
    {
        //If player is out of range,
        if (other.gameObject.tag == "Player")
        {
            //Resume chasing.
            animator.SetBool("Start Attacking", false);
            animator.SetBool("Attacking", false);
            animator.SetBool("Start Chasing", true);
            animator.SetBool("Chasing", true);
        }
    }
}
