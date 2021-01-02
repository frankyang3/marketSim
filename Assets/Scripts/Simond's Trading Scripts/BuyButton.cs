﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyButton : MonoBehaviour
{
    private int buyPrice = 3; // later use get component of the trader and change to private
    private int itemAvailable = 4; // later take the items available from the trader and change to private
    public Text buyText;
    // public string itemName;

    private void Start()
    {
        GameObject.Find("Buy Button").GetComponentInChildren<Text>().text = "Buy for $" + buyPrice + "  (" + itemAvailable + " left)";
    }

    private void Update()
    {
        
    }

    public void ReducePlayerGold()
    {
        if (itemAvailable > 0 && PlayerController.playerGold - buyPrice >= 0)
        {
            PlayerController.playerGold -= buyPrice;
            itemAvailable--;
            PlayerController.playerItem++;
            GameObject.Find("Buy Button").GetComponentInChildren<Text>().text = "Buy for $" + buyPrice + "  (" + itemAvailable + " left)";
        }
    }
}
