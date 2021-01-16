using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveFwd : MonoBehaviour
{
    private float speed = 15;
    private GameManager gameManagerScript;
    // Start is called before the first frame update
    void Start()
    {
        gameManagerScript = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManagerScript.isGameActive == true && gameManagerScript.isMovementActive)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);

        }
    }
}