using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyChase : MonoBehaviour {

    public GameObject player;
    public float chaseSpeed = 3.0f;
    public float chaseTriggerDistance = 3.0f;
    Vector3 startPosition;
    bool home = true;
    public Vector3 paceDirection = new Vector3(0, 0, 0);
    public float paceDistance = 3.0f;
    public float paceSpeed = 2.0f;
    public Animator Animator;
    Vector3 playerPosition;

    // Use this for initialization
    void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        startPosition = transform.position;
        Animator = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        Vector3 playerPosition = player.transform.position;
        //Vector from enemy position to the player's position:
        Vector3 chaseDirection = playerPosition - transform.position;
        //If player is close enough (within chaseTriggerDistance)
        if (chaseDirection.magnitude < chaseTriggerDistance)
        {
            //Then chase:
            home = false;
            chaseDirection.Normalize();
            GetComponent<Rigidbody>().velocity = chaseDirection * chaseSpeed;
            GetComponent<Animator>().SetBool("Start Chasing", true);
        }
        else if (home == false)
        {
            //Check how far away we are from home
            Vector3 homeDirection = startPosition - transform.position;
            //If we get close to home, reset our position to home
            //and reset our velocity.
            if (homeDirection.magnitude < 0.3f)
            {
                home = true;
                transform.position = startPosition;
                GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
                GetComponent<Animator>().SetBool("Pacing", false);
                GetComponent<Animator>().SetBool("Standing Still", true);
            }
            else
            {
                //Go home:
                homeDirection.Normalize();
                GetComponent<Rigidbody>().velocity = homeDirection * paceSpeed;
                GetComponent<Animator>().SetBool("Pacing", true);
            }
        }else
        {
            //Pace back and forth, because we're home
            //and the player isn't nearby
            Vector3 displacement = transform.position - startPosition;
            float distanceFromStart = displacement.magnitude;
            GetComponent<Animator>().SetBool("Standing Still", false);
            GetComponent<Animator>().SetBool("Start Pacing", true);


            if(distanceFromStart >= paceDistance)
            {
                //Flip directions
                paceDirection = -paceDirection;
            }
            paceDirection.Normalize();
            GetComponent<Rigidbody>().velocity = paceDirection * paceSpeed;
            GetComponent<Animator>().SetBool("Pacing", true);
        }
        
	}
}
