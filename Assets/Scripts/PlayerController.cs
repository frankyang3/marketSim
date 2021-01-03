using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Animator playerAnim;
    private GameManager gameManagerScript;

    public static int playerGold = 10;
    public static int playerItem = 3;

    public int tradeBuyPrice = 3; // Values are here to test, should be removed later
    public int tradeSellPrice = 1;
    public int tradeMaxBuy = 4;
    public int tradeMaxSell = 6;
    public BuyButton buyButton;
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
        if (gameManagerScript.isGameActive == true)
        {
            playerAnim.SetFloat("Speed_f", 1.0f);
        }
        else
        {
            playerAnim.SetFloat("Speed_f", 0f);
        }

        if (Input.GetKeyDown(KeyCode.Escape) && titleScreen.activeSelf is false){
            titleScreen.SetActive(true);
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && titleScreen.activeSelf is true)
        {
            titleScreen.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        tradeBuyPrice = other.gameObject.GetComponent<BasicMerchant>().buyPrice;
        tradeSellPrice = other.gameObject.GetComponent<BasicMerchant>().sellPrice;
        tradeMaxBuy = other.gameObject.GetComponent<BasicMerchant>().maxBuy;
        tradeMaxSell = other.gameObject.GetComponent<BasicMerchant>().maxSell;

        buyButton.UpdateBuyButton(tradeBuyPrice, tradeMaxBuy);
        gameManagerScript.OpenTradeWindow();

        Debug.Log("HIT");
    }
}
