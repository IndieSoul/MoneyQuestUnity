using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using Cinemachine;

public class Level1Manager : MonoBehaviour
{
    [Header("List Homeworks Object")]
    [SerializeField] private GameObject homeworksList;

    [Header("Complete")]
    public bool buyGroceries = false;
    public bool cutVegetable = false;
    public bool makeBed = false;
    public bool waterFlowers = false;
    public bool washcar = false;
    public bool washDishes = false;
    public bool bathDog = false;
    public bool cleanGarden = false;
    public bool fixTap = false;

    [Header("Complete")]
    public Image buyGroceriesImage;
    public Image cutVegetableImage;
    public Image makeBedImage;
    public Image waterFlowersImage;
    public Image washcarImage;
    public Image washDishesImage;
    public Image bathDogImage;
    public Image cleanGardenImage;
    public Image fixTapImage;

    public Slider timerSlider;
    public GameObject player;

    [Header("Colors")]
    public Color32 colorIncomplete;
    public Color32 colorComplete;

    [Header("Text")]
    public TextMeshProUGUI textScore;

    [Header("Players")]

    public GameObject girl;
    public GameObject boy;
    public CinemachineVirtualCamera virtualCamera;

    public float timerStart = 120;
    private float timer = 120;
    public bool timerRunning = false;

    private GameManager gameManager;

    private void Start() {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        timer = timerStart;
        timerRunning = true;

        // If girl selected
        if (gameManager.playerSelect == 0) {
            girl.SetActive(true);
            boy.SetActive(false);
            virtualCamera.Follow = girl.transform;
        } else {
            girl.SetActive(false);
            boy.SetActive(true);
            virtualCamera.Follow = boy.transform;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (buyGroceries) buyGroceriesImage.color = colorComplete;
        else buyGroceriesImage.color = colorIncomplete;

        if (cutVegetable) cutVegetableImage.color = colorComplete;
        else cutVegetableImage.color = colorIncomplete;

        if (makeBed) makeBedImage.color = colorComplete;
        else makeBedImage.color = colorIncomplete;

        if (waterFlowers) waterFlowersImage.color = colorComplete;
        else waterFlowersImage.color = colorIncomplete;

        if (washcar) washcarImage.color = colorComplete;
        else washcarImage.color = colorIncomplete;

        if (washDishes) washDishesImage.color = colorComplete;
        else washDishesImage.color = colorIncomplete;

        if (bathDog) bathDogImage.color = colorComplete;
        else bathDogImage.color = colorIncomplete;

        if (cleanGarden) cleanGardenImage.color = colorComplete;
        else cleanGardenImage.color = colorIncomplete;

        if (fixTap) fixTapImage.color = colorComplete;
        else fixTapImage.color = colorIncomplete;

        if (timerRunning == true)
        {
            timer -= Time.deltaTime;
            if(timer <= 0) {
                timerRunning = false;
                SceneManager.LoadScene("Level1");
            }
        }

        timerSlider.value = timer / timerStart;

        if (
            buyGroceries == true &&
            cutVegetable == true &&
            makeBed == true &&
            waterFlowers == true &&
            washcar == true &&
            washDishes == true &&
            bathDog == true &&
            cleanGarden == true &&
            fixTap == true
        ) 
        {
            player.SetActive(false);
            SceneManager.LoadScene("Level1Complete");
        }
    }

    public void GetScore() {
        gameManager.score += Random.Range(0, 6);
        if (Random.Range(0, 11) == 7) {
            gameManager.score += 5;
        }
        textScore.text = "Score: " + gameManager.score.ToString();
    }
    public void ShowHomeworksList() 
    {
        homeworksList.SetActive(!homeworksList.activeSelf);
    }
}
