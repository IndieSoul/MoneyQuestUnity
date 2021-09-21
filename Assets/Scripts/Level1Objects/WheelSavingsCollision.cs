using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelSavingsCollision : MonoBehaviour
{
   Level1CompleteManager levelManager;
    // Start is called before the first frame update
    void Start()
    {
        levelManager = GameObject.Find("MenuController").GetComponent<Level1CompleteManager>();
    }


    private void OnTriggerStay2D(Collider2D other) {
        if (other.gameObject.name == "Savings") {
            Invoke("Activate", 1);
            
        }
    }
    

    private void OnTriggerExit2D(Collider2D other) {
        if (other.gameObject.name == "Savings") {
            levelManager.savingsCorrect = false;
            CancelInvoke("Activate");
        }
    }

    private void Activate() {
        levelManager.savingsCorrect = true;
    }
}
