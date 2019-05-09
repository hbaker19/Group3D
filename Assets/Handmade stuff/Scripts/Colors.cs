using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Colors : MonoBehaviour
{
    public Material ColbyNormal;
    public Material ColbyAresen;
    public Material ColbyHannah;
    public Material ColbyRex;


    public Material RoboNormal;
    public Material RoboGoldnWhite;
    public Material RoboPinknPurple;
    public Material RoboBluenOrange;

    public GameObject Colby;
    public GameObject Robo;

    public RawImage CheckMarkColbyN;
    public RawImage CheckMarkColbyA;
    public RawImage CheckMarkColbyH;
    public RawImage CheckMarkColbyR;

    public RawImage CheckMarkRoboN;
    public RawImage CheckMarkRoboGnW;
    public RawImage CheckMarkRoboPinPu;
    public RawImage CheckMarkRoboBnO;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ColbyN()
    {
        Colby.GetComponent<SkinnedMeshRenderer>().material = ColbyNormal;
        CheckMarkColbyN.GetComponent<RawImage>().enabled = true;
        CheckMarkColbyA.GetComponent<RawImage>().enabled = false;
        CheckMarkColbyH.GetComponent<RawImage>().enabled = false;
        CheckMarkColbyR.GetComponent<RawImage>().enabled = false;
    }

    public void ColbyA()
    {
        Colby.GetComponent<SkinnedMeshRenderer>().material = ColbyAresen;
        CheckMarkColbyN.GetComponent<RawImage>().enabled = false;
        CheckMarkColbyA.GetComponent<RawImage>().enabled = true;
        CheckMarkColbyH.GetComponent<RawImage>().enabled = false;
        CheckMarkColbyR.GetComponent<RawImage>().enabled = false;
    }
    
    public void ColbyH()
    {
        CheckMarkColbyN.GetComponent<RawImage>().enabled = false;
        CheckMarkColbyA.GetComponent<RawImage>().enabled = false;
        CheckMarkColbyH.GetComponent<RawImage>().enabled = true;
        CheckMarkColbyR.GetComponent<RawImage>().enabled = false;
    }

    public void ColbyR()
    {
        CheckMarkColbyN.GetComponent<RawImage>().enabled = false;
        CheckMarkColbyA.GetComponent<RawImage>().enabled = false;
        CheckMarkColbyH.GetComponent<RawImage>().enabled = false;
        CheckMarkColbyR.GetComponent<RawImage>().enabled = true;
    }

    public void RoboN()
    {
        Robo.GetComponent<SkinnedMeshRenderer>().material = RoboNormal;
        CheckMarkRoboN.GetComponent<RawImage>().enabled = true;
        CheckMarkRoboGnW.GetComponent<RawImage>().enabled = false;
        CheckMarkRoboPinPu.GetComponent<RawImage>().enabled = false;
        CheckMarkRoboBnO.GetComponent<RawImage>().enabled = false;
    }

    public void RoboGnW()
    {
        Robo.GetComponent<SkinnedMeshRenderer>().material = RoboGoldnWhite;
        CheckMarkRoboN.GetComponent<RawImage>().enabled = false;
        CheckMarkRoboGnW.GetComponent<RawImage>().enabled = true;
        CheckMarkRoboPinPu.GetComponent<RawImage>().enabled = false;
        CheckMarkRoboBnO.GetComponent<RawImage>().enabled = false;
    }

    public void RoboPinPu()
    {
        CheckMarkRoboN.GetComponent<RawImage>().enabled = false;
        CheckMarkRoboGnW.GetComponent<RawImage>().enabled = false;
        CheckMarkRoboPinPu.GetComponent<RawImage>().enabled = true;
        CheckMarkRoboBnO.GetComponent<RawImage>().enabled = false;

    }

    public void RoboBnO()
    {
        CheckMarkRoboN.GetComponent<RawImage>().enabled = false;
        CheckMarkRoboGnW.GetComponent<RawImage>().enabled = false;
        CheckMarkRoboPinPu.GetComponent<RawImage>().enabled = false;
        CheckMarkRoboBnO.GetComponent<RawImage>().enabled = true;
    }

}
