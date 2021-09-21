using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L1BuyShop : MonoBehaviour
{
    private Level1Manager levelManager;
    public GameObject messageObject;
    public bool canBuy = false;

    private void Start() {
        levelManager = GameObject.Find("LevelManager").GetComponent<Level1Manager>();
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.gameObject.tag == "Player") canBuy = true;
    }

    private void OnTriggerExit2D(Collider2D other) 
    {
        if (other.gameObject.tag == "Player") canBuy = false;
    }
    
    private void Update() {
        if (canBuy && Input.GetKeyDown(KeyCode.Space)) 
        {
            if (canBuy == false) return;

            levelManager.GetScore();
            levelManager.buyGroceries = true;
            messageObject.SetActive(false);
            this.gameObject.SetActive(false);
        }
    }

    void OnMouseDown()
    {
        if (canBuy == false) return;

        levelManager.GetScore();
        levelManager.buyGroceries = true;
        messageObject.SetActive(false);
        this.gameObject.SetActive(false);
    }
}
