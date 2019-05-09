using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{


    public Canvas PauseMenu;
    public Canvas UI;
    public Canvas Customize3;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Pause"))
        {
            //If it is pressed, stop stuff form moving and make the pause menu visible to the naked eye.
            if (Time.timeScale == 1)
            {
                Time.timeScale = 0;
                PauseMenu.GetComponent<Canvas>().enabled = true;
                UI.GetComponent<Canvas>().enabled = false;
                Cursor.visible = false;
                Screen.lockCursor = false;
            }
            else
            {
                //unpause
                Resume();
            }

        }
    }

    public void Resume()
    {
        Time.timeScale = 1;
        PauseMenu.GetComponent<Canvas>().enabled = false;
        UI.GetComponent<Canvas>().enabled = true;
    }

    public void Customize()
    {
        PauseMenu.GetComponent<Canvas>().enabled = false;
        Customize3.GetComponent<Canvas>().enabled = true;

    }
}
