using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelNeedsCollision : MonoBehaviour
{
    Level1CompleteManager levelManager;
    // Start is called before the first frame update
    void Start()
    {
        levelManager = GameObject.Find("MenuController").GetComponent<Level1CompleteManager>();
    }


    private void OnTriggerStay2D(Collider2D other) {
        if (other.gameObject.name == "Needs") {
            Invoke("Activate", 1);
        }
    }
    

    private void OnTriggerExit2D(Collider2D other) {
        if (other.gameObject.name == "Needs") {
            levelManager.needsCorrect = false;
            CancelInvoke("Activate");
        }
    }

    private void Activate() {
        levelManager.needsCorrect = true;
    }
}
