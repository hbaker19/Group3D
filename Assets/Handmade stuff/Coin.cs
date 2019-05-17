using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Coin : MonoBehaviour {

    public int coinCount = 0;
    public Text Coins;
    public Text Nope;
    public Text End;
    public string scene;
	// Use this for initialization
	void Start () {
        Coins.GetComponent<Text>().text = coinCount + "/ 5 Shards";
        Nope.GetComponent<Text>().enabled = false;
    }
	
	// Update is called once per frame
	void Update () {
        Coins.GetComponent<Text>().text = coinCount + "/ 5 Shards";
        if (coinCount == 5f)
        {
            Coins.GetComponent<Text>().enabled = false;
            End.GetComponent<Text>().enabled = true;
        }
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Shard")
        {
            coinCount++;
            Destroy(collision.gameObject);
            
        }

        if (collision.gameObject.tag == "WinCrystal" && coinCount == 5f)
        {
            SceneManager.LoadScene(scene);
        }
        else if (collision.gameObject.tag == "WinCrystal")
        {
            Nope.GetComponent<Text>().enabled = true;
        }


    }

    
}
