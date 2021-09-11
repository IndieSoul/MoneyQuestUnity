using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L1MakeBed : MonoBehaviour
{
    private Level1Manager levelManager;
    public GameObject cleanBed;
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

        cleanBed.SetActive(true);
        levelManager.makeBed = true;
        messageObject.SetActive(false);
        this.gameObject.SetActive(false);
    }
}
