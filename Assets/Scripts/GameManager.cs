using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI timerText;
    public GameObject titleScreen;
    public GameObject gameOverScreen;
    public GameObject tradeWindow;
    private GameObject victoryScreen; 

    private int time = 300;
    private int playerGold;

    public bool isGameActive;
    public bool isMovementActive;
    // Start is called before the first frame update
    void Start()
    {
       victoryScreen = GameObject.Find("Victory Screen");
        tradeWindow.SetActive(false);
        timerText.enabled = false;
    }

    public void StartGame()
    {
        timerText.enabled = true;
        isMovementActive = true;
        isGameActive = true;
        titleScreen.SetActive(false);
        UpdateTimer(time);
        StartCoroutine(KeepTime());
    }

    public void OpenTradeWindow()
    {
        tradeWindow.SetActive(true);
    }

    public void HideTradeWindow()
    {
        tradeWindow.SetActive(false);
    }

    IEnumerator KeepTime()
    {
        while (isGameActive)
        {
            yield return new WaitForSeconds(1);
            time--;

            if (time < 0)
            {
                GameOver();
            }
            else
            {
                UpdateTimer(time);
            }
        }
    }

    public void UpdateScore()
    {

        playerGold = PlayerController.playerGold;
        if (playerGold < 1)
        {
            GameOver();
        }
        if(playerGold > 1000)
        {
            Victory();
        }
    }

    public void UpdateTimer(int timeRemaining)
    {
        if (isGameActive)
        {
            timerText.text = "Time: " + timeRemaining;
        }
    }

    public void GameOver()
    {
        gameOverScreen.SetActive(true);
        isGameActive = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Restart game by reloading the scene
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void Victory()
    {       
        victoryScreen.SetActive(true);
        isGameActive = false;
    }
}
