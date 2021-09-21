using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L1WashDishes : MonoBehaviour
{
    private Level1Manager levelManager;
    public GameObject dishesClean;
    public GameObject messageObject;
    public bool canDish = false;

    private void Start() {
        levelManager = GameObject.Find("LevelManager").GetComponent<Level1Manager>();
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.gameObject.tag == "Player") canDish = true;
    }

    private void OnTriggerExit2D(Collider2D other) 
    {
        if (other.gameObject.tag == "Player") canDish = false;
    }

    private void Update() {
        if (canDish && Input.GetKeyDown(KeyCode.Space))
        {
            if (canDish == false) return;

            levelManager.GetScore();
            dishesClean.SetActive(true);
            levelManager.washDishes = true;
            messageObject.SetActive(false);
            this.gameObject.SetActive(false);
        }
    }
    
    void OnMouseDown()
    {
        if (canDish == false) return;

        levelManager.GetScore();
        dishesClean.SetActive(true);
        levelManager.washDishes = true;
        messageObject.SetActive(false);
        this.gameObject.SetActive(false);
    }
}
