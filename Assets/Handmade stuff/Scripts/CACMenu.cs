using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CACMenu : MonoBehaviour
{

    //Shadow's Stuff
    public GameObject ShadowColor;
    public Canvas ShadowButtons;
    public Canvas ShadowNormalCanvas;
    public Canvas ShadowAreseneCanvas;
    public Canvas ShadowSophiaCanvas;
    public Canvas ShadowHollowCanvas;
    public Canvas ShadowBetaCanvas;
    public Material ShadowNormal;
    public Material ShadowAresene;
    public Material ShadowSophia;
    public Material ShadowHollow;
    public Material ShadowBeta;
    public RawImage ShadowCheckNormal;
    public RawImage ShadowCheckAresne;
    public RawImage ShadowCheckSophia;
    public RawImage ShadowCheckHollow;
    public RawImage ShadowCheckBeta;

    //Robo's Stuff
    public GameObject Robo;
    public Canvas RoboCanvas;

    //Sophia's Stuff
    public GameObject Sophia;
    public Canvas SophiaCanvas;

    //Hollow's Stuff
    public GameObject Hollow;
    public Canvas HollowCanvas;

    private void Start()
    {
        ShadowColor.GetComponent<SkinnedMeshRenderer>().enabled = true;
        ShadowNormalCanvas.GetComponent<Canvas>().enabled = true;
        ShadowButtons.GetComponent<Canvas>().enabled = true;
        Robo.GetComponent<SkinnedMeshRenderer>().enabled = false;
        RoboCanvas.GetComponent<Canvas>().enabled = false;
        Sophia.GetComponent<SkinnedMeshRenderer>().enabled = false;
        SophiaCanvas.GetComponent<Canvas>().enabled = false;
        Hollow.GetComponent<SkinnedMeshRenderer>().enabled = false;
        HollowCanvas.GetComponent<Canvas>().enabled = false;
    }
    
    public void ShadowCButton()
    {
        ShadowColor.GetComponent<SkinnedMeshRenderer>().enabled = true;
        ShadowNormalCanvas.GetComponent<Canvas>().enabled = true;
        ShadowButtons.GetComponent<Canvas>().enabled = true;
        Robo.GetComponent<SkinnedMeshRenderer>().enabled = false;
        RoboCanvas.GetComponent<Canvas>().enabled = false;
        Sophia.GetComponent<SkinnedMeshRenderer>().enabled = false;
        SophiaCanvas.GetComponent<Canvas>().enabled = false;
        Hollow.GetComponent<SkinnedMeshRenderer>().enabled = false;
        HollowCanvas.GetComponent<Canvas>().enabled = false;
    }

    public void ShadowCNormal()
    {
        ShadowColor.GetComponent<SkinnedMeshRenderer>().material = ShadowNormal;
        ShadowColor.GetComponent<SkinnedMeshRenderer>().enabled = true;
        ShadowNormalCanvas.GetComponent<Canvas>().enabled = true;
        ShadowButtons.GetComponent<Canvas>().enabled = true;
        ShadowAreseneCanvas.GetComponent<Canvas>().enabled = false;
        ShadowSophiaCanvas.GetComponent<Canvas>().enabled = false;
        ShadowHollowCanvas.GetComponent<Canvas>().enabled = false;
        ShadowBetaCanvas.GetComponent<Canvas>().enabled = false;
        ShadowCheckNormal.GetComponent<RawImage>().enabled = true;
        ShadowCheckAresne.GetComponent<RawImage>().enabled = false;
        ShadowCheckSophia.GetComponent<RawImage>().enabled = false;
        ShadowCheckHollow.GetComponent<RawImage>().enabled = false;
        ShadowCheckBeta.GetComponent<RawImage>().enabled = false;
        Robo.GetComponent<SkinnedMeshRenderer>().enabled = false;
        RoboCanvas.GetComponent<Canvas>().enabled = false;
        Sophia.GetComponent<SkinnedMeshRenderer>().enabled = false;
        SophiaCanvas.GetComponent<Canvas>().enabled = false;
        Hollow.GetComponent<SkinnedMeshRenderer>().enabled = false;
        HollowCanvas.GetComponent<Canvas>().enabled = false;
    }
    
    public void ShadowCAresene()
    {
        ShadowColor.GetComponent<SkinnedMeshRenderer>().material = ShadowAresene;
        ShadowNormalCanvas.GetComponent<Canvas>().enabled = false;
        ShadowAreseneCanvas.GetComponent<Canvas>().enabled = true;
        ShadowSophiaCanvas.GetComponent<Canvas>().enabled = false;
        ShadowHollowCanvas.GetComponent<Canvas>().enabled = false;
        ShadowBetaCanvas.GetComponent<Canvas>().enabled = false;
        ShadowCheckNormal.GetComponent<RawImage>().enabled = false;
        ShadowCheckAresne.GetComponent<RawImage>().enabled = true;
        ShadowCheckSophia.GetComponent<RawImage>().enabled = false;
        ShadowCheckHollow.GetComponent<RawImage>().enabled = false;
        ShadowCheckBeta.GetComponent<RawImage>().enabled = false;
    }

    public void ShadowCSophia()
    {
        ShadowColor.GetComponent<SkinnedMeshRenderer>().material = ShadowSophia;
        ShadowNormalCanvas.GetComponent<Canvas>().enabled = false;
        ShadowAreseneCanvas.GetComponent<Canvas>().enabled = false;
        ShadowSophiaCanvas.GetComponent<Canvas>().enabled = true;
        ShadowHollowCanvas.GetComponent<Canvas>().enabled = false;
        ShadowBetaCanvas.GetComponent<Canvas>().enabled = false;
        ShadowCheckNormal.GetComponent<RawImage>().enabled = false;
        ShadowCheckAresne.GetComponent<RawImage>().enabled = false;
        ShadowCheckSophia.GetComponent<RawImage>().enabled = true;
        ShadowCheckHollow.GetComponent<RawImage>().enabled = false;
        ShadowCheckBeta.GetComponent<RawImage>().enabled = false;
    }

    public void ShadowCHollow()
    {
        ShadowColor.GetComponent<SkinnedMeshRenderer>().material = ShadowHollow;
        ShadowNormalCanvas.GetComponent<Canvas>().enabled = false;
        ShadowAreseneCanvas.GetComponent<Canvas>().enabled = false;
        ShadowSophiaCanvas.GetComponent<Canvas>().enabled = false;
        ShadowHollowCanvas.GetComponent<Canvas>().enabled = true;
        ShadowBetaCanvas.GetComponent<Canvas>().enabled = false;
        ShadowCheckNormal.GetComponent<RawImage>().enabled = false;
        ShadowCheckAresne.GetComponent<RawImage>().enabled = false;
        ShadowCheckSophia.GetComponent<RawImage>().enabled = false;
        ShadowCheckHollow.GetComponent<RawImage>().enabled = true;
        ShadowCheckBeta.GetComponent<RawImage>().enabled = false;
    }
    
    public void ShadowCBeta()
    {
        ShadowColor.GetComponent<SkinnedMeshRenderer>().material = ShadowBeta;
        ShadowNormalCanvas.GetComponent<Canvas>().enabled = false;
        ShadowAreseneCanvas.GetComponent<Canvas>().enabled = false;
        ShadowSophiaCanvas.GetComponent<Canvas>().enabled = false;
        ShadowHollowCanvas.GetComponent<Canvas>().enabled = false;
        ShadowBetaCanvas.GetComponent<Canvas>().enabled = true;
        ShadowCheckNormal.GetComponent<RawImage>().enabled = false;
        ShadowCheckAresne.GetComponent<RawImage>().enabled = false;
        ShadowCheckSophia.GetComponent<RawImage>().enabled = false;
        ShadowCheckHollow.GetComponent<RawImage>().enabled = false;
        ShadowCheckBeta.GetComponent<RawImage>().enabled = true;
    }
    
    public void RoboButton()
    {
        ShadowColor.GetComponent<SkinnedMeshRenderer>().enabled = false;
        ShadowNormalCanvas.GetComponent<Canvas>().enabled = false;
        ShadowButtons.GetComponent<Canvas>().enabled = false;
        ShadowAreseneCanvas.GetComponent<Canvas>().enabled = false;
        ShadowSophiaCanvas.GetComponent<Canvas>().enabled = false;
        ShadowHollowCanvas.GetComponent<Canvas>().enabled = false;
        ShadowBetaCanvas.GetComponent<Canvas>().enabled = false;
        Robo.GetComponent<SkinnedMeshRenderer>().enabled = true;
        RoboCanvas.GetComponent<Canvas>().enabled = true;
        Sophia.GetComponent<SkinnedMeshRenderer>().enabled = false;
        SophiaCanvas.GetComponent<Canvas>().enabled = false;
        Hollow.GetComponent<SkinnedMeshRenderer>().enabled = false;
        HollowCanvas.GetComponent<Canvas>().enabled = false;
    }

    public void SophiaButton()
    {
        ShadowColor.GetComponent<SkinnedMeshRenderer>().enabled = false;
        ShadowNormalCanvas.GetComponent<Canvas>().enabled = false;
        ShadowButtons.GetComponent<Canvas>().enabled = false;
        ShadowAreseneCanvas.GetComponent<Canvas>().enabled = false;
        ShadowSophiaCanvas.GetComponent<Canvas>().enabled = false;
        ShadowHollowCanvas.GetComponent<Canvas>().enabled = false;
        ShadowBetaCanvas.GetComponent<Canvas>().enabled = false;
        Robo.GetComponent<SkinnedMeshRenderer>().enabled = false;
        RoboCanvas.GetComponent<Canvas>().enabled = false;
        Sophia.GetComponent<SkinnedMeshRenderer>().enabled = true;
        SophiaCanvas.GetComponent<Canvas>().enabled = true;
        Hollow.GetComponent<SkinnedMeshRenderer>().enabled = false;
        HollowCanvas.GetComponent<Canvas>().enabled = false;
    }
    
    public void HollowButton()
    {
        ShadowColor.GetComponent<SkinnedMeshRenderer>().enabled = false;
        ShadowButtons.GetComponent<Canvas>().enabled = false;
        ShadowNormalCanvas.GetComponent<Canvas>().enabled = false;
        ShadowAreseneCanvas.GetComponent<Canvas>().enabled = false;
        ShadowSophiaCanvas.GetComponent<Canvas>().enabled = false;
        ShadowHollowCanvas.GetComponent<Canvas>().enabled = false;
        ShadowBetaCanvas.GetComponent<Canvas>().enabled = false;
        Robo.GetComponent<SkinnedMeshRenderer>().enabled = false;
        RoboCanvas.GetComponent<Canvas>().enabled = false;
        Sophia.GetComponent<SkinnedMeshRenderer>().enabled = false;
        SophiaCanvas.GetComponent<Canvas>().enabled = false;
        Hollow.GetComponent<SkinnedMeshRenderer>().enabled = true;
        HollowCanvas.GetComponent<Canvas>().enabled = true;
    }


    





}
