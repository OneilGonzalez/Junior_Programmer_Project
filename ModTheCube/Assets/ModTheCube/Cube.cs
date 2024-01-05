using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    public float cubeScale = 2.5f;
    public Color startCubeColor = new Color(0.0f, 0.0f, 1.0f, 0.8f); //change color where(red, green, blue, fully opaque)
    public Color secondCubeColor = new Color(1.0f, 1.0f, 0.0f, 0.8f);
    public float rotationSpeed = 15.0f;
    public float colorChangeSpeed = 0.5f;
    
    private bool changingToSecond = true;
    
    void Start()
    {
        transform.position = new Vector3(3, 4, 1);
        transform.localScale = Vector3.one * cubeScale;
        
        Material material = Renderer.material;
        
        material.color = startCubeColor;
    }
    
    void Update()
    {
        transform.Rotate(rotationSpeed * Time.deltaTime, 0.0f, 0.0f);

        if (changingToSecond)
        {
            Renderer.material.color = Color.Lerp(Renderer.material.color, secondCubeColor, colorChangeSpeed * Time.deltaTime);
        }
        else
        {
            Renderer.material.color = Color.Lerp(Renderer.material.color, startCubeColor, colorChangeSpeed * Time.deltaTime);
        }


    }
}
