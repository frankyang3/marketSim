using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMerchant : MonoBehaviour
{
    //has its own speed, and prices
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

        buyPrice =  Random.Range(3, 10);
        sellPrice = CheckNegativeGold(buyPrice - Random.Range(1, 10));
        maxBuy = Random.Range(0, 10);
        maxSell = Random.Range(0, 10);

    }

    // Update is called once per frame
    void Update()
    {
        if (gameManagerScript.isGameActive == true && gameManagerScript.isMovementActive)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
        if (transform.position.x < -5)
        {
            Destroy(gameObject);
        }

    }

    // checks for negative gold, returns true or false
    private int CheckNegativeGold(int currentBuyPrice)
    {
        if (currentBuyPrice < 1)
        {
            return Random.Range(5, 20);
        }
        else
        {
            return currentBuyPrice;
        }
    }
}
