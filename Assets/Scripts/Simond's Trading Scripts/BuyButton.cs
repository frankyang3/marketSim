﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyButton : MonoBehaviour
{
    public int buyAmount = 1; // later use get component of the trader and change to private

    private void Start()
    {
        
    }

    public void reducePlayerGold()
    {
        PlayerController.playerGold -= buyAmount;
    }
}