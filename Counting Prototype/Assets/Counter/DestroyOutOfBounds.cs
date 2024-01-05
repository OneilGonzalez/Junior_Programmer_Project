using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    // Uncomment and set your left limit
    // private float leftLimit = 30;

    // Set your bottom limit
    private float bottomLimit = 0.26f;

    // Update is called once per frame
    void Update()
    {
        // Uncomment the next line and set your left limit
        // if (transform.position.x > leftLimit)
        // {
        //     Destroy(gameObject);
        // }
        
        // Destroy the object if y position is less than bottomLimit
        if (transform.position.y < bottomLimit)
        {
            Destroy(gameObject);
        }
    }
    
}
