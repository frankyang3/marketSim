using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] merchantTypes;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnMerchant", 4.0f, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnMerchant()
    {
        
        //try to generate merchant chnace
        int chance = Random.Range(0, 10);
        //generate merchant on left or right side
        int right = Random.Range(0, 1);
        if (chance > 6)
        {
            if (right == 1)
            {
                Instantiate(merchantTypes[0], new Vector3(80, 0, -20), merchantTypes[0].transform.rotation);
            }
            else
            {

            }
        }
        // instantiate ball at random spawn location
        //Instantiate();
    }
}

/**
 * 
 *  private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
    private float spawnInterval = 4.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomBall", startDelay, spawnInterval);
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);
        spawnInterval = Random.Range(3, 5);
        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[Random.Range(0,3)], spawnPos, ballPrefabs[0].transform.rotation);
    }
 * 
 * 
 * 
 */