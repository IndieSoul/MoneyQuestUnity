using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L1WaterFlowers : MonoBehaviour
{
    private Level1Manager levelManager;
    public GameObject waterNormal;
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

    private void Update() {
        if (canClean && Input.GetKeyDown(KeyCode.Space))
        {
            if (canClean == false) return;

            levelManager.GetScore();
            waterNormal.SetActive(true);
            levelManager.waterFlowers = true;
            messageObject.SetActive(false);
            this.gameObject.SetActive(false);
        }
    }
    
    void OnMouseDown()
    {
        if (canClean == false) return;

        levelManager.GetScore();
        waterNormal.SetActive(true);
        levelManager.waterFlowers = true;
        messageObject.SetActive(false);
        this.gameObject.SetActive(false);
    }
}
