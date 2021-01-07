using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemDisplay : MonoBehaviour
{
    private int playerItem;
    public Text playerItemText;
    private GameManager gameManager;


    // Start is called before the first frame update
    void Start()
    {
        playerItemText.enabled = false;
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManager.isGameActive)
        {
            playerItemText.enabled = true;
            playerItem = PlayerController.playerItem;
            playerItemText.text = "Items: " + playerItem;
        }
    }
}