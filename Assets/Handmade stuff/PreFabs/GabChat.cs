using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GabChat : MonoBehaviour
{
    public Canvas GabyChatH;
    public Canvas GabyChatRo;
    public Canvas GabyChatC;
    public Canvas GabyChatR;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Hannah")
        {
            GabyChatH.GetComponent<Canvas>().enabled = true;
        }
        else
        {
            GabyChatH.GetComponent<Canvas>().enabled = false;
        }

        
        if (other.gameObject.tag == "Rex")
        {

        }

        if (other.gameObject.tag == "Robo")
        {
            GabyChatRo.GetComponent<Canvas>().enabled = true;
        }else
        {
            GabyChatRo.GetComponent<Canvas>().enabled = false;
        }




  
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Hannah")
        {
            GabyChatH.GetComponent<Canvas>().enabled = false;
        }

        if (other.gameObject.tag == "Robo")
        {
            GabyChatRo.GetComponent<Canvas>().enabled = false;
        }
        
    }

}
