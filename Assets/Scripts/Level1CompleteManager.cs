using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1CompleteManager : MonoBehaviour
{
    public GameObject choosePanel;
    public GameObject allowancePanel;

    public void EnableChoosePanel() {
        choosePanel.SetActive(true);
        allowancePanel.SetActive(false);
    }
 }
