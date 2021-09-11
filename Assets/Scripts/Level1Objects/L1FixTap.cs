using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L1FixTap : MonoBehaviour
{
    private Level1Manager levelManager;
    public GameObject fixTap;
    public GameObject messageObject;
    public bool canFix = false;

    private void Start() {
        levelManager = GameObject.Find("LevelManager").GetComponent<Level1Manager>();
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.gameObject.tag == "Player") canFix = true;
    }

    private void OnTriggerExit2D(Collider2D other) 
    {
        if (other.gameObject.tag == "Player") canFix = false;
    }
    
    void OnMouseDown()
    {
        if (canFix == false) return;

        fixTap.SetActive(true);
        levelManager.fixTap = true;
        messageObject.SetActive(false);
        this.gameObject.SetActive(false);
    }
}
