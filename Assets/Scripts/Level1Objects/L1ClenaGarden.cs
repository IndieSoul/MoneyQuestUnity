using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L1ClenaGarden : MonoBehaviour
{
    private Level1Manager levelManager;
    public GameObject garbageClean;
    public GameObject messageObject;
    public bool canClean = false;

    private void Start() {
        levelManager = GameObject.Find("LevelManager").GetComponent<Level1Manager>();
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.gameObject.tag == "Player") canClean = true;
    }

    private void OnTriggerExit2D(Collider2D other) 
    {
        if (other.gameObject.tag == "Player") canClean = false;
    }
    
    void OnMouseDown()
    {
        if (canClean == false) return;

        garbageClean.SetActive(true);
        levelManager.cleanGarden = true;
        messageObject.SetActive(false);
        this.gameObject.SetActive(false);
    }
}