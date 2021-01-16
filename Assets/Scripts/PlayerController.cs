﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Animator playerAnim;
    private GameManager gameManagerScript;

    public static int playerGold = 10;
    //public static int playerItem = 3;
    public static int[] playerItems = { };

    //public int tradeBuyPrice = 3; // Values are here to test, should be removed later
    //public int tradeSellPrice = 1;
    //public int tradeMaxBuy = 4;
    //public int tradeMaxSell = 6;
    //public BuyButton buyButton;
    //public SellButton sellButton;

    // Start is called before the first frame update
    void Start()
    {
        playerAnim = GetComponent<Animator>();
        gameManagerScript = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManagerScript.isGameActive == true && gameManagerScript.isMovementActive )
        {
            playerAnim.SetFloat("Speed_f", 1.0f);
        }
        else
        {
            playerAnim.SetFloat("Speed_f", 0f);
        }

        
    }

    //private void OnTriggerEnter(Collider other)
    //{
    //    tradeBuyPrice = other.gameObject.GetComponent<BasicMerchant>().buyPrice;
    //    tradeSellPrice = other.gameObject.GetComponent<BasicMerchant>().sellPrice;
    //    tradeMaxBuy = other.gameObject.GetComponent<BasicMerchant>().maxBuy;
    //    tradeMaxSell = other.gameObject.GetComponent<BasicMerchant>().maxSell;

    //    Debug.Log(tradeBuyPrice);

    //    buyButton.UpdateBuyButton(tradeBuyPrice, tradeMaxBuy);

    //    sellButton.UpdateSellButton(tradeSellPrice, tradeMaxSell);


    //    gameManagerScript.isMovementActive = false;
    //    gameManagerScript.OpenTradeWindow();

    //}
}
