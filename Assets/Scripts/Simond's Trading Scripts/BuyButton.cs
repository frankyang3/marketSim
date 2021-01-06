using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyButton : MonoBehaviour
{
    public int buyPrice; // later use get component of the trader and change to private
    public int itemAvailable; // later take the items available from the trader and change to private
    public Text buyText;
    private GameManager gameManager;
    // public string itemName;

    private void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();

        buyText = GameObject.Find("Buy Button").GetComponentInChildren<Text>();
        buyText.text = "Buy for $" + buyPrice + "  (" + itemAvailable + " left)";
        Button btn = gameObject.GetComponent<Button>();
        btn.onClick.AddListener(ReducePlayerGold);
    }

    private void Update()
    {
        
    }

    public void UpdateBuyButton(int priceMerchant, int itemLimit)
    {
        buyPrice = priceMerchant;
        itemAvailable = itemLimit;
        buyText.text = "Buy for $" + buyPrice + "  (" + itemAvailable + " left)";
        Debug.Log("INSIDE HERE" + buyPrice);
    }

    public void ReducePlayerGold()
    {
        Debug.Log("BuyPrice" + buyPrice);

        if (itemAvailable > 0 && PlayerController.playerGold - buyPrice >= 0)
        {
            PlayerController.playerGold -= buyPrice;
            itemAvailable--;
            PlayerController.playerItem++;
            GameObject.Find("Buy Button").GetComponentInChildren<Text>().text = "Buy for $" + buyPrice + "  (" + itemAvailable + " left)";
        }
        gameManager.UpdateScore();
    }
}
