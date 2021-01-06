﻿using System.Collections;
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
    public GameObject victoryScreen; 

    private int time = 300;
    private int playerGold;
    private int playerItem;

    public bool isGameActive;
    public bool isMovementActive;
    // Start is called before the first frame update
    void Start()
    {
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
                GameOver(false);
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
        playerItem = PlayerController.playerItem;
        if (playerGold < 3 && playerItem < 1)
        {
            GameOver(false);
        }
        else if(playerGold >= 1000)
        {
            GameOver(true);
        }
    }

    public void UpdateTimer(int timeRemaining)
    {
        if (isGameActive)
        {
            timerText.text = "Time: " + timeRemaining;
        }
    }

    public void GameOver(bool is_win)
    {
        tradeWindow.SetActive(false);
        if (is_win)
        {
            victoryScreen.SetActive(true);
        }
        else
        {
            gameOverScreen.SetActive(true);
        }
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
        PlayerController.playerGold = 10;
        PlayerController.playerItem = 3;
    }
}
