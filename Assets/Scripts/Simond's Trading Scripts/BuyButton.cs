﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyButton : MonoBehaviour
{
    private int buyPrice = 0; // later use get component of the trader and change to private
    private int itemAvailable = 0; // later take the items available from the trader and change to private
    public Text buyText;
    // public string itemName;

    private void Start()
    {
        buyText = GameObject.Find("Buy Button").GetComponentInChildren<Text>();
        buyText.text = "Buy for $" + buyPrice + "  (" + itemAvailable + " left)";
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
    }
}
