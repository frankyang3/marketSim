using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RareMerchant : MonoBehaviour
{
    private GameManager gameManagerScript;
    private float speed = 15;
    public int timePrice = 15;
    public int time = 15;

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
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
        if (transform.position.x < -5)
        {
            Destroy(gameObject);
        }
    }
}
