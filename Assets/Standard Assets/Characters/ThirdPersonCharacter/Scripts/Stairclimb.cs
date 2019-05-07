using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Stairclimb : MonoBehaviour
{
    float h = CrossPlatformInputManager.GetAxis("Horizontal");
    float v = CrossPlatformInputManager.GetAxis("Vertical");
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Stairs")
        {
            GetComponent<Rigidbody>().drag = Mathf.Infinity;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (this.GetComponent<Rigidbody>().drag == Mathf.Infinity)
        {
            GetComponent<Rigidbody>().drag = 3;
        }
    }
}
