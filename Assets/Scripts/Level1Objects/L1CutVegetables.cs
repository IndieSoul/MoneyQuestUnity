using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L1CutVegetables : MonoBehaviour
{
    private Level1Manager levelManager;
    public GameObject carrotCut;
    public GameObject messageObject;
    public bool canCut = false;

    private void Start() {
        levelManager = GameObject.Find("LevelManager").GetComponent<Level1Manager>();
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.gameObject.tag == "Player") canCut = true;
    }

    private void OnTriggerExit2D(Collider2D other) 
    {
        if (other.gameObject.tag == "Player") canCut = false;
    }

    private void Update() {
        if (canCut && Input.GetKeyDown(KeyCode.Space))
        {
            if (canCut == false) return;

            levelManager.GetScore();
            carrotCut.SetActive(true);
            levelManager.cutVegetable = true;
            messageObject.SetActive(false);
            this.gameObject.SetActive(false);
        }
    }
    
    void OnMouseDown()
    {
        if (canCut == false) return;

        levelManager.GetScore();
        carrotCut.SetActive(true);
        levelManager.cutVegetable = true;
        messageObject.SetActive(false);
        this.gameObject.SetActive(false);
    }
}
