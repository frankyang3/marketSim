using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI timerText;

    private int time = 60;

    public bool isGameActive;

    // Start is called before the first frame update
    void Start()
    {
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
        //playerGold += scoreToAdd; temporary variable, need simond to modify/unite it
        //scoreText.text = "Score: " + playerGold; // temporary variable, need simond to modify/unite it
    }

    public void UpdateTimer(int timeRemaining)
    {
        timerText.text = "Time: " + timeRemaining;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
