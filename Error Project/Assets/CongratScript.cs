using System.Collections;
using UnityEngine;

public class CongratScript : MonoBehaviour
{
    public TextMesh Text;
    public ParticleSystem SparksParticles;

    private string TextToDisplay;  // Assuming it's a single string

    private float RotatingSpeed;
    private float TimeToNextText;

    private int CurrentText;

    // Start is called before the first frame update
    void Start()
    {
        TimeToNextText = 0.8f;
        CurrentText = 0;


        // Initialize TextToDisplay with a default message
        TextToDisplay = "Congratulations";

        Text.text = TextToDisplay;

        SparksParticles.Play();
    }

    // Update is called once per frame
    void Update()
    {
        TimeToNextText += Time.deltaTime ;

        if (TimeToNextText > 1.5f)
        {
            TimeToNextText = 0.0f;

            // Reset CurrentText when it reaches the end of the string
            if (CurrentText >= TextToDisplay.Length)
            {
                CurrentText = 0;
            }

            // Update Text with the next character in the string
            Text.text = TextToDisplay.Substring(0, CurrentText + 1);

            CurrentText++;
        }
    }
}
