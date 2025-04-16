using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JuicyClick : MonoBehaviour
{
    float difference = 0f;
    float dimRate = 0.2f;
    bool hasPopped = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (hasPopped)
        {
            Screen.brightness -= dimRate * difference;
        }
    }

    public void BrightPop()
    {
        float baseBrightness = Screen.brightness;
        difference = 1.0f - baseBrightness;
        Screen.brightness = 1.0f;
        hasPopped = true;
    }
}
