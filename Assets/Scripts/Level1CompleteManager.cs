using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Playables;

public class Level1CompleteManager : MonoBehaviour
{
    [Header("Panels")]
    public GameObject choosePanel;
    public GameObject allowancePanel;
    public TextMeshProUGUI textDog;
    private GameManager gameManager;
    private bool directorPlaying = false;
    [SerializeField] private PlayableDirector directorUnderstanding;


    [Header("Choose Game")]
    [SerializeField] private Button buttonGoingShoop;
    [SerializeField] private Sprite buttonGoingShoopSprite;
    private bool buttonGoingShoopEnable = false;

    [SerializeField] private Button buttonCallingFrends;
    [SerializeField] private Sprite buttonCallingFrendsSprite;
    private bool buttonCallingFrendsEnable = false;

    [SerializeField] private Button buttonCeaningGarden;
    [SerializeField] private Sprite buttonCeaningGardenSprite;
    private bool buttonCeaningGardenEnable = false;

    [SerializeField] private Button buttonWateringPlants;
    [SerializeField] private Sprite buttonWateringPlantsSprite;
    private bool buttonWateringPlantsEnable = false;

    [SerializeField] private Button buttonPlayingDog;
    [SerializeField] private Sprite buttonPlayingDogSprite;
    private bool buttonPlayingDogEnable = false;

    [SerializeField] private Button buttonMakingBed;
    [SerializeField] private Sprite buttonMakingBedSprite;
    private bool buttonMakingBedEnable = false;

    [SerializeField] private Button buttonPaintingHouse;
    [SerializeField] private Sprite buttonPaintingHouseSprite;
    private bool buttonPaintingHouseEnable = false;

    [SerializeField] private Button buttonBathingDog;
    [SerializeField] private Sprite buttonBathingDogSprite;
    private bool buttonBathingDogEnable = false;

    [SerializeField] private Button buttonWashingCar;
    [SerializeField] private Sprite buttonWashingCarSprite;
    private bool buttonWashingCarEnable = false;

    [SerializeField] private Button buttonDoingDishes;
    [SerializeField] private Sprite buttonDoingDishesSprite;
    private bool buttonDoingDishesEnable = false;

    [SerializeField] private Button buttonReadingComic;
    [SerializeField] private Sprite buttonReadingComicSprite;
    private bool buttonReadingComicEnable = false;

    [SerializeField] private Button buttonWatchingCartoon;
    [SerializeField] private Sprite buttonWatchingCartoonSprite;
    private bool buttonWatchingCartoonEnable = false;

    [SerializeField] private Button buttonRepairingItem;
    [SerializeField] private Sprite buttonRepairingItemSprite;
    private bool buttonRepairingItemEnable = false;

    [SerializeField] private Button buttonPlayingToys;
    [SerializeField] private Sprite buttonPlayingToysSprite;
    private bool buttonPlayingToysEnable = false;

    [SerializeField] private Button buttonPlateUncleaned;
    [SerializeField] private Sprite buttonPlateUncleanedSprite;
    private bool buttonPlateUncleanedEnable = false;

    [Header("Choose")]
    [SerializeField] private GameObject nextButtonChoose;
    [SerializeField] private TextMeshProUGUI textScore;

    [Header("Wheel")]
    public bool needsCorrect = false;
    public bool savingsCorrect = false;
    public bool wantsCorrect = false;
    public bool wheelComplete = false;
    [SerializeField] private GameObject wheelPanelUI;
    [SerializeField] private GameObject wheelPanel;
    [SerializeField] private GameObject wellDonePanel;
     [SerializeField] private GameObject coinDrop;

    public void ButtonGoingShoop() {
        if (buttonGoingShoopEnable == true) return;
        buttonGoingShoopEnable = true;

        buttonGoingShoop.image.sprite = buttonGoingShoopSprite;
        GetPoints ();
    }

    public void ButtonCallingFrends() {
        if (buttonCallingFrendsEnable == true) return;
        buttonCallingFrendsEnable = true;

        buttonCallingFrends.image.sprite = buttonCallingFrendsSprite;
        LostPoints();
    }
    public void ButtonCeaningGarden() {
        if (buttonCeaningGardenEnable == true) return;
        buttonCeaningGardenEnable = true;

        buttonCeaningGarden.image.sprite = buttonCeaningGardenSprite;
        GetPoints ();
    }
    public void ButtonWateringPlants() {
        if (buttonWateringPlantsEnable == true) return;
        buttonWateringPlantsEnable = true;

        buttonWateringPlants.image.sprite = buttonWateringPlantsSprite;
        GetPoints ();
    }
    public void ButtonPlayingDog() {
        if (buttonPlayingDogEnable == true) return;
        buttonPlayingDogEnable = true;

        buttonPlayingDog.image.sprite = buttonPlayingDogSprite;
        LostPoints();
    }
    public void ButtonMakingBed() {
        if (buttonMakingBedEnable == true) return;
        buttonMakingBedEnable = true;

        buttonMakingBed.image.sprite = buttonMakingBedSprite;
        LostPoints();
    }
    public void ButtonPaintingHouse() {
        if (buttonPaintingHouseEnable == true) return;
        buttonPaintingHouseEnable = true;

        buttonPaintingHouse.image.sprite = buttonPaintingHouseSprite;
        GetPoints ();
    }
    public void ButtonBathingDog() {
        if (buttonBathingDogEnable == true) return;
        buttonBathingDogEnable = true;

        buttonBathingDog.image.sprite = buttonBathingDogSprite;
        GetPoints ();
    }
    public void ButtonWashingCar() {
        if (buttonWashingCarEnable == true) return;
        buttonWashingCarEnable = true;

        buttonWashingCar.image.sprite = buttonWashingCarSprite;
        GetPoints ();
    }
    public void ButtonDoingDishes() {
        if (buttonDoingDishesEnable == true) return;
        buttonDoingDishesEnable = true;

        buttonDoingDishes.image.sprite = buttonDoingDishesSprite;
        GetPoints ();
    }
    public void ButtonReadingComic() {
        if (buttonReadingComicEnable == true) return;
        buttonReadingComicEnable = true;

        buttonReadingComic.image.sprite = buttonReadingComicSprite;
        LostPoints();
    }
    public void ButtonWatchingCartoon() {
        if (buttonWatchingCartoonEnable == true) return;
        buttonWatchingCartoonEnable = true;

        buttonWatchingCartoon.image.sprite = buttonWatchingCartoonSprite;
        LostPoints();
    }
    public void ButtonRepairingItem() {
        if (buttonRepairingItemEnable == true) return;
        buttonRepairingItemEnable = true;

        buttonRepairingItem.image.sprite = buttonRepairingItemSprite;
        GetPoints ();
    }
    public void ButtonPlayingToys() {
        if (buttonPlayingToysEnable == true) return;
        buttonPlayingToysEnable = true;

        buttonPlayingToys.image.sprite = buttonPlayingToysSprite;
        LostPoints();
    }
    public void ButtonPlateUncleaned() {
        if (buttonPlateUncleanedEnable == true) return;
        buttonPlateUncleanedEnable = true;

        buttonPlateUncleaned.image.sprite = buttonPlateUncleanedSprite;
        LostPoints();
    }

    private void Update() {
        textDog.text = "You gained " + gameManager.score + " money points! You have been very smart and helpful too! Let's go to the next level!"; 
        if (
            buttonGoingShoopEnable == true &&
            buttonCeaningGardenEnable == true &&
            buttonWateringPlantsEnable == true &&
            buttonRepairingItemEnable == true &&
            buttonPaintingHouseEnable == true &&
            buttonBathingDogEnable == true &&
            buttonWashingCarEnable == true &&
            buttonDoingDishesEnable == true
            ) 
        {
            if(directorPlaying == false) {
                directorPlaying = true;
                directorUnderstanding.Play();
                allowancePanel.SetActive(false);
                choosePanel.SetActive(false);
            }
        } 

        if (
            savingsCorrect == true &&
            needsCorrect == true &&
            wantsCorrect == true
            ) 
        {
            if(wheelComplete == false) {
                wheelComplete = true;
                wheelPanel.SetActive(false);
                wheelPanelUI.SetActive(false);
                wellDonePanel.SetActive(true);
                coinDrop.SetActive(true);
            }
        } 
    }

    private void GetPoints () {
        gameManager.score += Random.Range(1, 6);
        textScore.text = "Score: " + gameManager.score;
    }

    private void LostPoints () {
        gameManager.score -= Random.Range(1, 4);
        textScore.text = "Score: " + gameManager.score;
    }

    private void Start() {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        textDog.text = "You gained " + gameManager.score + " money points! You have been very smart and helpful too! Let's go to the next level!"; 
    }

    public void EnableChoosePanel() {
        choosePanel.SetActive(true);
        allowancePanel.SetActive(false);
    }

    public void PlayTimelineUnderstanding() 
    {
        directorPlaying = true;
        directorUnderstanding.Play();
        allowancePanel.SetActive(false);
        choosePanel.SetActive(false);
    }
 }
