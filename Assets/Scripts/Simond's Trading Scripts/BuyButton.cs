using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyButton : MonoBehaviour
{
    private int buyAmount = 1; // later use get component of the trader and change to private
    private int itemAvailable = 4; // later take the items available from the trader and change to private
    public Text buyText;
    // public string itemName;

    private void Start()
    {
        GameObject.Find("Buy Button").GetComponentInChildren<Text>().text = "Buy for $" + buyAmount + "  (" + itemAvailable + " left)";
    }

    private void Update()
    {
        
    }

    public void reducePlayerGold()
    {
        if (itemAvailable > 0)
        {
            PlayerController.playerGold -= buyAmount;
            itemAvailable--;
            Debug.Log("this is itemAvaiable: " + itemAvailable);
            Debug.Log("this is buyText: ", buyText);
            GameObject.Find("Buy Button").GetComponentInChildren<Text>().text = "Buy for $" + buyAmount + "  (" + itemAvailable + " left)";
        }
    }
}
