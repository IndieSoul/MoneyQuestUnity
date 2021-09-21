using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class GameManager : MonoBehaviour
{
    public static GameManager gameManager;
    public string playerName = "";
    public string playerAge = "";
    public int playerSelect = 0;

    public int score = 0;

    private void Awake()
    {
        if (gameManager != null && gameManager != this)
             Destroy(this.gameObject);
         else
         {
             gameManager = this;
             DontDestroyOnLoad(this.gameObject);
         }
    }
}
