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
            GetComponent<Animator>().SetBool("Looking Around", false);
            GetComponent<Animator>().SetBool("Start Chasing", true);
            GetComponent<Animator>().SetBool("Chasing", true);
            GetComponent<Animator>().SetBool("Going Home", false);
        }
        else if ((transform.position - home).magnitude >= 1){
            //Otherwise, go home.
            agent.destination = home;
            GetComponent<Animator>().SetBool("Start Chasing", false);
            GetComponent<Animator>().SetBool("Chasing", false);
            GetComponent<Animator>().SetBool("Going Home", true);
        }
        else
        {
            
            GetComponent<Animator>().SetBool("Looking Around", true);
        }
        Debug.Log(transform.position + " " + home);
    }

    private void OnTriggerEnter(Collider other)
    {
        //If the enemy walks into a trigger on the player,
        if (other.gameObject.tag == "Player")
        {
            //Start attacking.
            GetComponent<Animator>().SetBool("Start Attacking", true);
            GetComponent<Animator>().SetBool("Attacking", true);
            GetComponent<Animator>().SetBool("Start Chasing", false);
            GetComponent<Animator>().SetBool("Chasing", false);
        }   
    }

    private void OnTriggerExit(Collider other)
    {
        //If player is out of range,
        if (other.gameObject.tag == "Player")
        {
            //Resume chasing.
            GetComponent<Animator>().SetBool("Start Attacking", false);
            GetComponent<Animator>().SetBool("Attacking", false);
            GetComponent<Animator>().SetBool("Start Chasing", true);
            GetComponent<Animator>().SetBool("Chasing", true);
        }
    }
}
