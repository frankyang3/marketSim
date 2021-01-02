﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMerchant : MonoBehaviour
{
    private float speed = 15;
    private GameManager gameManagerScript;


    public int buyPrice;
    public int sellPrice;
    public int maxBuy;
    public int maxSell;

    // Start is called before the first frame update
    void Start()
    {
        gameManagerScript = GameObject.Find("Game Manager").GetComponent<GameManager>();

        buyPrice = PlayerController.playerGold - Random.Range(0, 10);
        sellPrice = buyPrice + Random.Range(1, 20);
        maxBuy = Random.Range(0, 100);
        maxSell = Random.Range(0, 100);

    }

    // Update is called once per frame
    void Update()
    {
        if (gameManagerScript.isGameActive == true)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
        if (transform.position.x < -5)
        {
            Destroy(gameObject);
        }

    }
}
