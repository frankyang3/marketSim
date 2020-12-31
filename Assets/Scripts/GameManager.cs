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

    private int time = 60;

    public bool isGameActive;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void StartGame()
    {
        isGameActive = true;
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
                //GameOver();
            }
            else
            {
                UpdateTimer(time);
            }
        }
    }

    public void UpdateScore(int scoreToAdd)
    {
        //playerGold += scoreToAdd; TODO: temporary variable, need simond to modify/unite it
        //scoreText.text = "Score: " + playerGold; // TODO: temporary variable, need simond to modify/unite it
        //if (playerGold > 1000 || playerGold < 1)
        //{
        //    gameOver();
        //}
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
