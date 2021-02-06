using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Animator playerAnim;
    private GameManager gameManagerScript;

    public static int playerGold = 10;
    public static int playerItem = 3;
    public static int[] playerItems = { };

    public int time;
    public int timePrice;
    public int tradeBuyPrice = 3; // Values are here to test, should be removed later
    public int tradeSellPrice = 1;
    public int tradeMaxBuy = 4;
    public int tradeMaxSell = 6;

    public BuyTimeButton buyTimeButton;
    public BuyButton buyButton;
    public SellButton sellButton;
    public GameObject titleScreen;

    // Start is called before the first frame update
    void Start()
    {
        playerAnim = GetComponent<Animator>();
        gameManagerScript = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        //checks if game is running and not paused, then makes guy move 
        if (gameManagerScript.isGameActive == true && gameManagerScript.isMovementActive )
        {
            playerAnim.SetFloat("Speed_f", 1.0f);
        }
        else
        {
            playerAnim.SetFloat("Speed_f", 0f);
        }

        
    }

    private void OnTriggerEnter(Collider other) //checks merchant type and generates values accordingly
    {
        if (other.gameObject.CompareTag("Basic Merchant"))
        {
            tradeBuyPrice = other.gameObject.GetComponent<BasicMerchant>().buyPrice;
            tradeSellPrice = other.gameObject.GetComponent<BasicMerchant>().sellPrice;
            tradeMaxBuy = other.gameObject.GetComponent<BasicMerchant>().maxBuy;
            tradeMaxSell = other.gameObject.GetComponent<BasicMerchant>().maxSell;
            Debug.Log(tradeBuyPrice);
            buyButton.UpdateBuyButton(tradeBuyPrice, tradeMaxBuy);
            sellButton.UpdateSellButton(tradeSellPrice, tradeMaxSell);
            gameManagerScript.isMovementActive = false;
            gameManagerScript.OpenTradeWindow();
        }              

        else if (other.gameObject.CompareTag("Rare Merchant"))
        {
            time = other.gameObject.GetComponent<RareMerchant>().time;
            timePrice = other.gameObject.GetComponent<RareMerchant>().timePrice;
            buyTimeButton.UpdateBuyTimeButton(time, timePrice);
            gameManagerScript.isMovementActive = false;
            gameManagerScript.OpenTimeWindow();
        }     
    }
}
