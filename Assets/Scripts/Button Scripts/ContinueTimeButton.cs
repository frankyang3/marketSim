using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContinueTimeButton : MonoBehaviour
{
    private GameManager gameManagerScript;
    private Button button;
    // Start is called before the first frame update
    void Start()
    {
        gameManagerScript = GameObject.Find("Game Manager").GetComponent<GameManager>();
        button = GetComponent<Button>();
        button.onClick.AddListener(Continue);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Continue()
    {
        gameManagerScript.isMovementActive = true;
        gameManagerScript.HideTimeWindow();
    }
}
