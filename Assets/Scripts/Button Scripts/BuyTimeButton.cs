using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyTimeButton : MonoBehaviour
{
    public int timePrice = 15;
    public int time = 15;
    public Text buyTimeText;
    private Button button;
    private GameManager gameManagerScript;

    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(AddTime);
        gameManagerScript = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateBuyTimeButton(int timeX, int priceX)
    {
        time = timeX;
        timePrice = priceX;
        buyTimeText.text = "Buy" + time + "seconds for $" + timePrice + "?";
    }

    public void AddTime()
    {   
        if (PlayerController.playerGold >= 15)
        {
            PlayerController.playerGold -= timePrice;
            gameManagerScript.time += time;
        }
        
    }
}
