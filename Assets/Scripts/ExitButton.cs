using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitButton : MonoBehaviour
{
    private Button button;
    public GameObject titleScreen;
    public GameObject gameOverScreen;
    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(ExitToTitle);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ExitToTitle()
    {
        Debug.Log("ada");
        titleScreen.SetActive(true);
        gameOverScreen.SetActive(false);
    }
}
    
