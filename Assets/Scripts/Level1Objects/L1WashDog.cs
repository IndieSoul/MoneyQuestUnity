using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L1WashDog : MonoBehaviour
{
    private Level1Manager levelManager;
    public GameObject dogClean;
    public GameObject messageObject;
    public bool canBath = false;

    private void Start() {
        levelManager = GameObject.Find("LevelManager").GetComponent<Level1Manager>();
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.gameObject.tag == "Player") canBath = true;
    }

    private void OnTriggerExit2D(Collider2D other) 
    {
        if (other.gameObject.tag == "Player") canBath = false;
    }
    
    void OnMouseDown()
    {
        if (canBath == false) return;

        dogClean.SetActive(true);
        levelManager.bathDog = true;
        messageObject.SetActive(false);
        this.gameObject.SetActive(false);
    }
}
