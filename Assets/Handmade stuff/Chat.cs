using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Chat : MonoBehaviour
{
    public RawImage Speak;
    public Canvas HannahChatC;
    public Canvas UI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag =="Hannah")
        {
            Speak.GetComponent<RawImage>().enabled = true;
            if(Input.GetButtonDown("Fire1") && Time.timeScale == 1)
            {
                Time.timeScale = 0;
                UI.GetComponent<Canvas>().enabled = false;
                HannahChatC.GetComponent<Canvas>().enabled = true;
            }
        }

    }

    public void StopChat()
    {
        Time.timeScale = 1;
        UI.GetComponent<Canvas>().enabled = true;
        HannahChatC.GetComponent<Canvas>().enabled = false;
    }
}
