using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    [SerializeField] private GameObject startPanel;
    [SerializeField] private GameObject helloPanel;
    [SerializeField] private GameObject badgesPanel;
    [SerializeField] private GameObject chooseAvatarPanel;
    [SerializeField] private GameObject yourNamePanel;
    [SerializeField] private GameObject yourAgePanel;
    [SerializeField] private GameObject stage1Inst1Panel;
    [SerializeField] private GameObject stage2Inst1Panel;
    [SerializeField] private GameObject pathwayPanel;

    public void StartPanelEnable() 
    {
        startPanel.SetActive(true);

        helloPanel.SetActive(false);
        badgesPanel.SetActive(false);
        chooseAvatarPanel.SetActive(false);
        yourNamePanel.SetActive(false);
        yourAgePanel.SetActive(false);
        stage1Inst1Panel.SetActive(false);
        stage2Inst1Panel.SetActive(false);
        pathwayPanel.SetActive(false);
    }

    public void HelloPanelEnable() 
    {
        helloPanel.SetActive(true);

        startPanel.SetActive(false);
        badgesPanel.SetActive(false);
        chooseAvatarPanel.SetActive(false);
        yourNamePanel.SetActive(false);
        yourAgePanel.SetActive(false);
        stage1Inst1Panel.SetActive(false);
        stage2Inst1Panel.SetActive(false);
        pathwayPanel.SetActive(false);
    }

    public void BadgesPanelEnable() 
    {
        badgesPanel.SetActive(true);

        startPanel.SetActive(false);
        helloPanel.SetActive(false);
        chooseAvatarPanel.SetActive(false);
        yourNamePanel.SetActive(false);
        yourAgePanel.SetActive(false);
        stage1Inst1Panel.SetActive(false);
        stage2Inst1Panel.SetActive(false);
        pathwayPanel.SetActive(false);
    }

    public void ChooseAvatarPanelEnable() 
    {
        chooseAvatarPanel.SetActive(true);

        startPanel.SetActive(false);
        helloPanel.SetActive(false);
        badgesPanel.SetActive(false);
        yourNamePanel.SetActive(false);
        yourAgePanel.SetActive(false);
        stage1Inst1Panel.SetActive(false);
        stage2Inst1Panel.SetActive(false);
        pathwayPanel.SetActive(false);
    }

    public void YourNamePanelEnable() 
    {
        yourNamePanel.SetActive(true);

        startPanel.SetActive(false);
        helloPanel.SetActive(false);
        badgesPanel.SetActive(false);
        chooseAvatarPanel.SetActive(false);
        yourAgePanel.SetActive(false);
        stage1Inst1Panel.SetActive(false);
        stage2Inst1Panel.SetActive(false);
        pathwayPanel.SetActive(false);
    }

    public void YourAgePanelEnable() 
    {
        yourAgePanel.SetActive(true);

        startPanel.SetActive(false);
        helloPanel.SetActive(false);
        badgesPanel.SetActive(false);
        chooseAvatarPanel.SetActive(false);
        yourNamePanel.SetActive(false);
        stage1Inst1Panel.SetActive(false);
        stage2Inst1Panel.SetActive(false);
        pathwayPanel.SetActive(false);
    }

    public void Stage1Inst1PanelEnable() 
    {
        stage1Inst1Panel.SetActive(true);

        startPanel.SetActive(false);
        helloPanel.SetActive(false);
        badgesPanel.SetActive(false);
        chooseAvatarPanel.SetActive(false);
        yourNamePanel.SetActive(false);
        yourAgePanel.SetActive(false);
        stage2Inst1Panel.SetActive(false);
        pathwayPanel.SetActive(false);
    }

    public void Stage1Inst2PanelEnable() 
    {
        stage2Inst1Panel.SetActive(true);

        startPanel.SetActive(false);
        helloPanel.SetActive(false);
        badgesPanel.SetActive(false);
        chooseAvatarPanel.SetActive(false);
        yourNamePanel.SetActive(false);
        yourAgePanel.SetActive(false);
        stage1Inst1Panel.SetActive(false);
        pathwayPanel.SetActive(false);
    }

    public void PathwayPanelEnable() 
    {
        pathwayPanel.SetActive(true);

        startPanel.SetActive(false);
        helloPanel.SetActive(false);
        badgesPanel.SetActive(false);
        chooseAvatarPanel.SetActive(false);
        yourNamePanel.SetActive(false);
        yourAgePanel.SetActive(false);
        stage1Inst1Panel.SetActive(false);
        stage2Inst1Panel.SetActive(false);
    }

    public void GoToGame() 
    {
        SceneManager.LoadScene("Level1");
    }
}
