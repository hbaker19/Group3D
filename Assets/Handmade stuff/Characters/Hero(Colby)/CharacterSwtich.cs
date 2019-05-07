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
    public Image RBImage;
    public Image LBImage;

    public Canvas UI;

    // Start is called before the first frame update
    void Start()
    {
        Colby = GameObject.Find("Colby (Player)");
        Robo = GameObject.Find("Robo (Player)");

        ColbyCam = GameObject.Find("Camera.C");
        RoboCam = GameObject.Find("Camera.R");

        RoboImage.GetComponent<Image>().enabled = true;
        ColbyImage.GetComponent<Image>().enabled = false;

        RBImage.GetComponent<Image>().enabled = true;
        LBImage.GetComponent<Image>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire3") && RoboImage == true)
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
            RoboImage.GetComponent<Image>().enabled = false;

            RBImage.GetComponent<Image>().enabled = false;
            LBImage.GetComponent<Image>().enabled = true;

        }
        else if (Input.GetButtonDown("Fire2") && ColbyImage == true)
        {
            Colby.GetComponent<Rigidbody>().isKinematic = false;
            Robo.GetComponent<Rigidbody>().isKinematic = true;

            Colby.GetComponent<ThirdPersonCharacter>().enabled = true;
            Colby.GetComponent<ThirdPersonUserControl>().enabled = true;

            Robo.GetComponent<ThirdPersonCharacter>().enabled = false;
            Robo.GetComponent<ThirdPersonUserControl>().enabled = false;

            ColbyCam.GetComponent<Camera>().enabled = true;
            RoboCam.GetComponent<Camera>().enabled = false;

            ColbyImage.GetComponent<Image>().enabled = false;
            RoboImage.GetComponent<Image>().enabled = true;

            RBImage.GetComponent<Image>().enabled = true;
            LBImage.GetComponent<Image>().enabled = false;
        }
    }
}
