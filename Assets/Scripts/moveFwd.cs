using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveFwd : MonoBehaviour
{
    private float speed = 15;
    private PlayerController playerControllerScript;
    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {

            transform.Translate(Vector3.forward * Time.deltaTime * speed);

    }
}
