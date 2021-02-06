using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class repeatHouses : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -20)
        {
            if (transform.position.z > 10)
            {
                transform.position = new Vector3(388f, 0f, 21f);
            }else
            {
                transform.position = new Vector3(388f, 0f, -33f);
            }
        }
        
    }
}
