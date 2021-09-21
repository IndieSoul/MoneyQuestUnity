using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelWantsCollision : MonoBehaviour
{
    Level1CompleteManager levelManager;
    // Start is called before the first frame update
    void Start()
    {
        levelManager = GameObject.Find("MenuController").GetComponent<Level1CompleteManager>();
    }


    private void OnTriggerStay2D(Collider2D other) {
        if (other.gameObject.name == "Wants") {
            Invoke("Activate", 1);
        }
    }
    

    private void OnTriggerExit2D(Collider2D other) {
        if (other.gameObject.name == "Wants") {
            levelManager.wantsCorrect = false;
            CancelInvoke("Activate");
        }
    }

    private void Activate() {
        levelManager.wantsCorrect = true;
    }
}
