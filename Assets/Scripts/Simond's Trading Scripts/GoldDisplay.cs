using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoldDisplay : MonoBehaviour
{
    private int playerGold;
    public Text playerGoldText;
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        
        playerGoldText.enabled = false;
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(gameManager.isGameActive is true)
        {
            playerGoldText.enabled = true;
            playerGold = PlayerController.playerGold;
            playerGoldText.text = "Gold: " + playerGold;

            // Testing if its changable
            if (Input.GetKeyDown(KeyCode.Space))
            {
                PlayerController.playerGold--;
            }
        }      
    }
}
