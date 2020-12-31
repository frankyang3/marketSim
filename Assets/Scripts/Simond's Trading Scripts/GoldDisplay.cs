using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoldDisplay : MonoBehaviour
{
    public int playerGold;
    public Text playerGoldText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerGoldText.text = "Gold: " + playerGold;

        // Testing if its changable
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerGold--;
        }
    }
}
