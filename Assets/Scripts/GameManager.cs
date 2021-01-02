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

    private int time = 60;
    private int playerGold;

    public bool isGameActive;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void StartGame()
    {
        isGameActive = true;
        titleScreen.SetActive(false);
        UpdateTimer(time);
        StartCoroutine(KeepTime());
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
        scoreText.text = "Score: " + playerGold;
        if (playerGold > 1000 || playerGold < 1)
        {
            GameOver();
        }
    }

    public void UpdateTimer(int timeRemaining)
    {
        timerText.text = "Time: " + timeRemaining;
    }

    public void GameOver()
    {
        //gameOverText.gameObject.SetActive(true); TODO: need adam to check
        //restartButton.gameObject.SetActive(true); TODO: need adam to check
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

}
