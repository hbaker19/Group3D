using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
            }
            else
            {
                //unpause
                Resume();
                //Cursor.visible = false;
                //Cursor.lockState = CursorLockMode.Locked;
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
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public void BacktoPause()
    {
        Time.timeScale = 0;
        PauseMenu.GetComponent<Canvas>().enabled = true;
        Customize3.GetComponent<Canvas>().enabled = false;
    }
    
    public void MainMenu()
    {
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1;
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void NewGame()
    {
        SceneManager.LoadScene("World 1");
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
    }

    public void CACCA()
    {
        SceneManager.LoadScene("CACMenu");
    }
}
