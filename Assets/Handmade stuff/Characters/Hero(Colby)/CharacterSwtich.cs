using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.ThirdPerson;

public class CharacterSwtich : MonoBehaviour
{

    public GameObject Colby;
    public GameObject Robo;

    public GameObject ColbyCam;
    public GameObject RoboCam;

    public Image ColbyImage;
    public Image RoboImage;

    public Canvas UI;

    // Start is called before the first frame update
    void Start()
    {
        Colby = GameObject.Find("Colby (Player)");
        Robo = GameObject.Find("Robo (Player)");

        ColbyCam = GameObject.Find("Camera.C");
        RoboCam = GameObject.Find("Camera.R");

        

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire3") && RoboImage == false)
        {

            Colby.GetComponent<Rigidbody>().isKinematic = true;
            Robo.GetComponent<Rigidbody>().isKinematic = false;

            Colby.GetComponent<ThirdPersonCharacter>().enabled = false;
            Colby.GetComponent<ThirdPersonUserControl>().enabled = false;

            Robo.GetComponent<ThirdPersonCharacter>().enabled = true;
            Robo.GetComponent<ThirdPersonUserControl>().enabled = true;

            ColbyCam.GetComponent<Camera>().enabled = false;
            RoboCam.GetComponent<Camera>().enabled = true;

            ColbyImage.GetComponent<Image>().enabled = true;

        }
    }
}
