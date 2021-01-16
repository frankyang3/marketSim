using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuitButton : MonoBehaviour
{
    private Button button;
    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(OnApplicationQuit);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Quits game
    private void OnApplicationQuit()
    {
        Application.Quit();
    }
}
