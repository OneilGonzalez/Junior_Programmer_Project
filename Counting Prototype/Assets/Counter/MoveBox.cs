using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBox : MonoBehaviour
{   
    public int speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float verticalInput = Input.GetAxis("Vertical");
        float movementAmount = verticalInput * speed * Time.deltaTime;

        // Move the object along the Z-axis (forward and backward)
        transform.position += new Vector3(0f, 0f, movementAmount);
    }
}
