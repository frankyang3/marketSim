using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SellButton : MonoBehaviour
{
    private int sellPrice = 1;
    private int amountBuying = 6;
    public Text sellText;
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();

        sellText = GameObject.Find("Sell Button").GetComponentInChildren<Text>();
        sellText.text = "Sell for $" + sellPrice + "  (Amount willing to buy " + amountBuying + ")";
        Button btn = gameObject.GetComponent<Button>();
        btn.onClick.AddListener(IncreasePlayerGold);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateSellButton(int merchantSellPrice, int itemLimit)
    {
        sellPrice = merchantSellPrice;
        amountBuying = itemLimit;
        sellText.text = "Sell for $" + sellPrice + "  (Amount willing to buy " + amountBuying + ")";
    }

    public void IncreasePlayerGold()
    {
        if (PlayerController.playerItem > 0 && amountBuying > 0)
        {
            PlayerController.playerGold += sellPrice;
            PlayerController.playerItem--;
            amountBuying--;
            GameObject.Find("Sell Button").GetComponentInChildren<Text>().text = "Sell for $" + sellPrice + "  (Amount willing to buy " + amountBuying + ")";
        }
        gameManager.UpdateScore();
    }
}
